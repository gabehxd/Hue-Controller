using System;
using System.Drawing;
using System.Windows.Forms;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.Gamut;
using Newtonsoft.Json;
using Q42.HueApi.ColorConverters.HSB;
using Q42.HueApi.Interfaces;
using System.Linq;
using Cyotek.Windows.Forms;
using Q42.HueApi.Models.Groups;
using System.Collections.Generic;
using Q42.HueApi.ColorConverters.Original;
using System.IO;

namespace Hue_Controller
{
    public partial class MainForm : Form
    {
        private Color Color;
        private LightFinder LightFinder = new LightFinder();
        private BridgeFinder BridgeFinder = new BridgeFinder();
        public static readonly FileInfo ConfigFile = new FileInfo("Config.Json");

        public MainForm() => InitializeComponent();

        private void BridgeFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BridgeFinder.IsDisposed) BridgeFinder = new BridgeFinder();
            BridgeFinder.Show();
            BridgeFinder.Activate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Config cfg = new Config();
            if (ConfigFile.Exists && JsonConvert.DeserializeObject(File.ReadAllText(ConfigFile.FullName), typeof(Config)) is Config JSON) cfg = JSON;

            foreach (object item in Enum.GetValues(typeof(Alert)))
                AlertType.Items.Add(item);
            AlertType.SelectedItem = cfg.Alert;

            foreach (object item in Enum.GetValues(typeof(Effect)))
                EffectType.Items.Add(item);
            EffectType.SelectedItem = cfg.Effect;

            isLightOn.Checked = cfg.On;
            KeyBox.Text = cfg.Key;
            IPBox.Text = cfg.IP;
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            ColorPickerDialog picker = new ColorPickerDialog();

            if (picker.ShowDialog() == DialogResult.OK)
            {
                ColorBtn.BackColor = picker.Color;
                Color = picker.Color;
            }
        }

        private async void SendCommand_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(IPBox.Text))
            {
                MessageBox.Show("Hue Bridge IP is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(KeyBox.Text))
            {
                MessageBox.Show("Hue Bridge key is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AlertType.SelectedItem == null)
            {
                MessageBox.Show("Alert type not selected/not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EffectType.SelectedItem == null)
            {
                MessageBox.Show("Effect type not selected/not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ILocalHueClient client = new LocalHueClient(IPBox.Text, KeyBox.Text);

            if (!await client.CheckConnection())
            {
                MessageBox.Show("Bridge conntection test failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LightCommand command = new LightCommand
            {
                On = isLightOn.Checked,
                Alert = (Alert)AlertType.SelectedItem
            };

            if (!((Effect)EffectType.SelectedItem == Effect.ColorLoop)) command.SetColor(new RGBColor(Color.R, Color.G, Color.B));
            command.Effect = (Effect)EffectType.SelectedItem;

            var result = await client.SendCommandAsync(command);
            IEnumerable<DefaultHueResult> Errors = result.Where(x => x.Error != null);
            if (Errors.Count() != 0)
            {
                string errmsg = "Error(s) have occured\n";
                foreach (DefaultHueResult ErrorResult in Errors)
                    errmsg += $"{ErrorResult.Error.Address} {ErrorResult.Error.Description}\n";

                MessageBox.Show(errmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Success", "Lights Command", MessageBoxButtons.OK, MessageBoxIcon.None);
                JsonConvert.SerializeObject(new Config(IPBox.Text, KeyBox.Text, isLightOn.Checked, (Alert)AlertType.SelectedItem, (Effect)EffectType.SelectedItem, Color));
            }
        }

        private void EffectTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EffectType.SelectedItem != null && (Effect)EffectType.SelectedItem == Effect.ColorLoop) ColorBtn.Enabled = false;
            else ColorBtn.Enabled = true;
        }

        private void LightFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LightFinder.IsDisposed) LightFinder = new LightFinder();
            LightFinder.Show();
            LightFinder.Activate();
        }
    }
    public class Config
    {
        public string IP;
        public string Key;
        public bool On;
        public Alert Alert;
        public Effect Effect;
        public Color Color;

        public Config(string address, string code, bool status, Alert AlertType, Effect EffectType, Color Selected)
        {
            IP = address;
            Key = code;
            On = status;
            Alert = AlertType;
            Effect = EffectType;
            Color = Selected;
        }

        public Config()
        {
            IP = "";
            Key = "";
            On = true;
            Alert = Alert.None;
            Effect = Effect.None;
            Color = Color.White;
        }
    }
}

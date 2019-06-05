using Cyotek.Windows.Forms;
using Newtonsoft.Json;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.Gamut;
using Q42.HueApi.ColorConverters.HSB;
using Q42.HueApi.ColorConverters.Original;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Groups;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            Color = cfg.Color;
            ColorBtn.BackColor = cfg.Color;
            Selected.Text = cfg.Selected;
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            ColorPickerDialog picker = new ColorPickerDialog
            {
                Color = Color
            };

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
                On = isLightOn.Checked
            };

            if (isLightOn.Checked)
            {
                if (!((Effect)EffectType.SelectedItem == Effect.ColorLoop)) command.SetColor(new RGBColor(Color.R, Color.G, Color.B));
                command.Effect = (Effect)EffectType.SelectedItem;
                command.Alert = (Alert)AlertType.SelectedItem;
            }
            
            HueResults result;
            if (string.IsNullOrWhiteSpace(Selected.Text))
            {
                result = await client.SendCommandAsync(command);
            }
            else
            {
                if (Selected.Text.Contains("!"))
                {
                    if (!Selected.Text.Split(' ').All(x => x.StartsWith("!")))
                    {
                        MessageBox.Show("Invalid Light selection (not all lights started with '!') ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    IEnumerable<Light> lights = await client.GetLightsAsync();
                    string[] requestedIds = Selected.Text.Split(' ');
                    IEnumerable<Light> requestedLights = lights.Where(l => requestedIds.Contains(l.Id));
                    result = await client.SendCommandAsync(command, requestedLights.Select(l => l.Id).ToArray());
                }
                else result = await client.SendCommandAsync(command, Selected.Text.Split(' '));

            }

            IEnumerable<DefaultHueResult> Errors = result.Where(x => x.Error != null);
            if (Errors.Count() == 0)
            {
                MessageBox.Show("Success", "Lights Command", MessageBoxButtons.OK, MessageBoxIcon.None);
                File.WriteAllText(ConfigFile.FullName, JsonConvert.SerializeObject(new Config()
                {
                    On = isLightOn.Checked,
                    Key = KeyBox.Text,
                    Alert = (Alert)AlertType.SelectedItem,
                    Color = Color,
                    Effect = (Effect)EffectType.SelectedItem,
                    IP = IPBox.Text
                }));
            }
            else
            {
                string errmsg = "Error(s) have occured\n";
                foreach (DefaultHueResult ErrorResult in Errors)
                    errmsg += $"{ErrorResult.Error.Address}: {ErrorResult.Error.Description}\n";

                MessageBox.Show(errmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void IsLightOn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isLightOn.Checked)
            {
                AlertType.Enabled = false;
                EffectType.Enabled = false;
                ColorBtn.Enabled = false;
            }
            else
            {
                AlertType.Enabled = true;
                EffectType.Enabled = true;
                if ((Effect)EffectType.SelectedItem != Effect.ColorLoop) ColorBtn.Enabled = true;
            }
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
        public string Selected;

        public Config()
        {
            IP = string.Empty;
            Key = string.Empty;
            On = true;
            Alert = Alert.None;
            Effect = Effect.None;
            Color = Color.White;
            Selected = string.Empty;
        }
    }
}

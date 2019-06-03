using System;
using System.Drawing;
using System.Windows.Forms;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.Gamut;
using Q42.HueApi.ColorConverters.HSB;
using Q42.HueApi.Interfaces;
using System.Linq;
using Cyotek.Windows.Forms;
using Q42.HueApi.Models.Groups;
using System.Collections.Generic;
using Q42.HueApi.ColorConverters.Original;

namespace Hue_Controller
{
    public partial class MainForm : Form
    {
        private Color Color;

        public MainForm() => InitializeComponent();

        private void BridgeFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BridgeFinder bridgeFinder = new BridgeFinder();
            bridgeFinder.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (object item in Enum.GetValues(typeof(Alert)))
                AlertType.Items.Add(item);
            AlertType.SelectedIndex = 0;

            foreach (object item in Enum.GetValues(typeof(Effect)))
                EffectTypes.Items.Add(item);
            EffectTypes.SelectedIndex = 0;
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
            if (EffectTypes.SelectedItem == null)
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

            if (!((Effect)EffectTypes.SelectedItem == Effect.ColorLoop)) command.SetColor(new RGBColor(Color.R, Color.G, Color.B));
            command.Effect = (Effect)EffectTypes.SelectedItem;

            var result = await client.SendCommandAsync(command);
            IEnumerable<DefaultHueResult> Errors = result.Where(x => x.Error != null);
            if (Errors.Count() != 0)
            {
                string errmsg = "Error(s) have occured";
                foreach (DefaultHueResult ErrorResult in Errors)
                {
                    errmsg += $"{ErrorResult.Error.Address} {ErrorResult.Error.Description}\n";
                }
                MessageBox.Show(errmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Success", "Lights Command", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void EffectTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EffectTypes.SelectedItem != null && (Effect)EffectTypes.SelectedItem == Effect.ColorLoop) ColorBtn.Enabled = false;
            else ColorBtn.Enabled = true;
        }

        private void LightFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LightFinder lightFinder = new LightFinder();
            lightFinder.Show();
        }
    }
}

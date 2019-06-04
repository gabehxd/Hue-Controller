using Newtonsoft.Json;
using Q42.HueApi;
using Q42.HueApi.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hue_Controller
{
    public partial class LightFinder : Form
    {
        public LightFinder()
        {
            InitializeComponent();
        }

        private async void Button1_ClickAsync(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            if (string.IsNullOrWhiteSpace(bridgeIP_Box.Text))
            {
                MessageBox.Show("Hue Bridge IP is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(bridgePass_Box.Text))
            {
                MessageBox.Show("Hue Bridge key is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ILocalHueClient client = new LocalHueClient(bridgeIP_Box.Text, bridgePass_Box.Text);

            if (!await client.CheckConnection())
            {
                MessageBox.Show("Bridge conntection test failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IEnumerable<Light> Lights = await client.GetLightsAsync();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                List<string> list = new List<string>();
                foreach (Light light in Lights)
                    list.Add($"{light.Id}: {light.Name}");

                richTextBox1.Lines = list.ToArray();
            }
            else
            {
                Light light = null;
                try
                {
                    light = Lights.Single(x => x.Id == textBox1.Text);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("A light with that ID was not found!", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Just in case
                if (light == null)
                {
                    MessageBox.Show("A light with that ID was not found!", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //T R A S H
                richTextBox1.Lines = new string[] {
                    "General Info:",
                    $"Name: {light.Name}",
                    $"ID: {light.Id}",
                    $"Product ID: {light.ProductId}",
                    $"Unique ID: {light.UniqueId}",
                    $"Luminaire Unique ID: {light.LuminaireUniqueId}",
                    $"Manufacturer Name: {light.ManufacturerName}",
                    $"Software Version Name: {light.SoftwareVersion}",
                    $"Type: {light.Type}",
                    $"SW Config ID: {light.SwConfigId}",
                    $"SW Update: {light.SwUpdate}",
                    "",
                    "Config:",
                    $"Arche Type: {light.Config.ArcheType}",
                    $"Direction: {light.Config.Direction}",
                    $"Function: {light.Config.Function}",
                    "",
                    "Startup:",
                    $"Configured: {light.Config.Startup.Configured}",
                    $"Mode: {light.Config.Startup.Mode}",
                    "",
                    "State:",
                    $"On: {light.State.On}",
                    $"Brightness: {light.State.Brightness}",
                    $"Hue: {light.State.Hue}",
                    $"Saturation: {light.State.Saturation}",
                    $"Color Mode: {light.State.ColorMode}",
                    $"Alert: {light.State.Alert}",
                    $"Effect: {light.State.Effect}",
                    $"Color Temperature: {light.State.ColorTemperature}",
                    $"Color Coordinates: {light.State.ColorCoordinates}",
                    $"Transition Time: {light.State.TransitionTime}",
                    $"Is Reachable: {light.State.IsReachable}"
                };
            }
            UseWaitCursor = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            //Config constructor always needs some color
            Config cfg = new Config(Color.White);
            if (MainForm.ConfigFile.Exists && JsonConvert.DeserializeObject(File.ReadAllText(MainForm.ConfigFile.FullName), typeof(Config)) is Config JSON) cfg = JSON;
            bridgeIP_Box.Text = cfg.IP;
            bridgePass_Box.Text = cfg.Key;
        }
    }
}

﻿using Newtonsoft.Json;
using Q42.HueApi;
using Q42.HueApi.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Hue_Controller
{
    public partial class LightFinder : Form
    {
        public LightFinder() => InitializeComponent();


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
                richTextBox1.Lines = new string[]
                {
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
                    $"SW Update State: {light.SwUpdate.State}",
                    $"Last SW Update Time: {light.SwUpdate.Lastinstall.Value}",
                    string.Empty,
                    "Config:",
                    $"Arche Type: {light.Config.ArcheType}",
                    $"Direction: {light.Config.Direction}",
                    $"Function: {light.Config.Function}",
                    string.Empty,
                    "Startup:",
                    $"Configured: {light.Config.Startup.Configured.Value}",
                    $"Mode: {light.Config.Startup.Mode.Value}",
                    string.Empty,
                    "State:",
                    $"On: {light.State.On}",
                    $"Brightness: {light.State.Brightness}",
                    $"Hue: {light.State.Hue.Value}",
                    $"Saturation: {light.State.Saturation.Value}",
                    $"Color Mode: {light.State.ColorMode}",
                    $"Alert: {light.State.Alert}",
                    $"Effect: {light.State.Effect.Value}",
                    $"Color Temperature: {light.State.ColorTemperature.Value}",
                    //I'm almost certain there is only 2 coords
                    $"Color Coordinates: X: {light.State.ColorCoordinates[0]}, Y: {light.State.ColorCoordinates[1]}",
                    $"Transition Time: {light.State.TransitionTime.Value}",
                    $"Is Reachable: {light.State.IsReachable.Value}"
                };
            }
            UseWaitCursor = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Config cfg = new Config();
            if (MainForm.ConfigFile.Exists && JsonConvert.DeserializeObject(File.ReadAllText(MainForm.ConfigFile.FullName), typeof(Config)) is Config JSON) cfg = JSON;
            bridgeIP_Box.Text = cfg.IP;
            bridgePass_Box.Text = cfg.Key;
        }

        private void SaveTextToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }
    }
}

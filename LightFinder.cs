using Q42.HueApi;
using Q42.HueApi.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            var Lights = await client.GetLightsAsync();
            string txt = "";
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                
                foreach (Light light in Lights)
                {
                    txt += $"{light.Id}: {light.Name}\n";
                }
                richTextBox1.Text = txt;
            }
            else
            {

            }
        }
    }
}

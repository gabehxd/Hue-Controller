using Q42.HueApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Q42.HueApi.Models.Bridge;

namespace Hue_Controller
{
    public partial class BridgeFinder : Form
    {
        public BridgeFinder() => InitializeComponent();

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
            IEnumerable<LocatedBridge> Enum = await new HttpBridgeLocator().LocateBridgesAsync(TimeSpan.FromSeconds(5));
            LocatedBridge[] Bridges = Enum.ToArray();
            if (Bridges.Count() > 0)
            {
                List<string> list = new List<string>();
                for (int i = 0; i < Bridges.Count(); i++)
                {
                    LocatedBridge item = Bridges[i];
                    list.Add($"{item.BridgeId}: {item.IpAddress}");
                }
                richTextBox1.Lines = list.ToArray();
            }
            else MessageBox.Show("No bridges found!", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            UseWaitCursor = false;
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

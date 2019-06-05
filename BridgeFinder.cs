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
            IEnumerable<LocatedBridge> Bridges = await new HttpBridgeLocator().LocateBridgesAsync(TimeSpan.FromSeconds(5));

            if (Bridges.Count() > 0) richTextBox1.Lines = Bridges.Select(b => $"{b.BridgeId}: {b.IpAddress}").ToArray();
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

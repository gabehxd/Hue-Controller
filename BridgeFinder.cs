using Q42.HueApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Q42.HueApi.Models.Bridge;

namespace Hue_Controller
{
    public partial class BridgeFinder : Form
    {
        public BridgeFinder() => InitializeComponent();

        private async void Button1_ClickAsync(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            IEnumerable<LocatedBridge> Enum = await new HttpBridgeLocator().LocateBridgesAsync(TimeSpan.FromSeconds(5));
            LocatedBridge[] Bridges = Enum.ToArray();
            if (Bridges.Count() > 0)
            {
                label1.Visible = false;
                List<string> list = new List<string>();
                for (int i = 0; i < Bridges.Count(); i++)
                {
                    LocatedBridge item = Bridges[i];
                    list.Add($"{item.BridgeId}: {item.IpAddress}");
                }
                richTextBox1.Lines = list.ToArray();
            }
            else label1.Visible = true;
            UseWaitCursor = false;
        }
    }
}

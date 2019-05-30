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
            IEnumerable<LocatedBridge> Bridges = await new HttpBridgeLocator().LocateBridgesAsync(TimeSpan.FromSeconds(5));
            if (Bridges.Count() > 0)
            {
                label1.Visible = false;
                foreach (LocatedBridge item in Bridges)
                    listView1.Columns.Add($"{item.BridgeId}: {item.IpAddress}", -2, HorizontalAlignment.Left);
            }
            else label1.Visible = true;
        }
    }
}

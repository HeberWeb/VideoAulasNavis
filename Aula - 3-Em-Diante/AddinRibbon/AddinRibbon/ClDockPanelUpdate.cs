using AddinRibbon.Ctr;
using Autodesk.Navisworks.Api.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddinRibbon
{
    /// <summary>
    /// Aula 4
    /// </summary>
    [Plugin("ClDockPanelUpdate", "AUTODOC", DisplayName = "Dynamic Update")]
    [DockPanePlugin(200,400, AutoScroll = true, MinimumHeight = 100, MinimumWidth = 200)]
    class ClDockPanelUpdate : DockPanePlugin
    {
        public override Control CreateControlPane()
        {
            return new UcUpdate() { Dock = DockStyle.Fill };
        }

        public override void DestroyControlPane(Control pane)
        {
            try
            {
                var ctr = (UcUpdate)pane;
                ctr?.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

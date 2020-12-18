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
        /// <summary>
        /// Aula 4 e 6 Edições tab pages
        /// </summary>
        /// <returns></returns>
        public override Control CreateControlPane()
        {
            TabControl tc = new TabControl();
            tc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            tc.PaddingChanged += SetDockStyle;
            
            TabPage tp1 = new TabPage("Auto Update");
            
            tp1.Controls.Add(new UcUpdate() { Dock = DockStyle.Fill });
            tc.TabPages.Add(tp1);

            TabPage tp2 = new TabPage("Properties");
            tp2.Controls.Add(new UcProperties() { Dock = DockStyle.Fill });
            tc.TabPages.Add(tp2);

            return tc;
        }

        private void SetDockStyle(object sender, EventArgs e)
        {
            TabControl tc = sender as TabControl;
            tc.Dock = DockStyle.Fill;
        }

        public override void DestroyControlPane(Control pane)
        {
            try
            {
                var ctr = (TabControl)pane;
                ctr?.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

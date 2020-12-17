using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Navisworks.Api.Plugins;

namespace AddinRibbon
{
    [Plugin("AddinRibbon", "AUTODOC", DisplayName = "AddinRibbon")]
    [RibbonLayout("AddinRibbon.xaml")]
    [RibbonTab("ID_Custom_1", DisplayName = "Teste Ribbon")]
    [Command("ID_Button_1", Icon = "icon-logoautodoc-16.png", LargeIcon = "icon-logoautodoc-32.png", ToolTip = "Show a Message")]
    public class ClAddin : CommandHandlerPlugin
    {
        public override int ExecuteCommand(string name, params string[] parameters)
        {
            switch (name)
            {
                case "ID_Button_1":

                    if (!Autodesk.Navisworks.Api.Application.IsAutomated)
                    {
                        var pluginRecord = Autodesk.Navisworks.Api.Application.Plugins.FindPlugin("ClDockPanelUpdate.AUTODOC");

                        if (pluginRecord is DockPanePluginRecord && pluginRecord.IsEnabled)
                        {
                            var dockPanel = (DockPanePlugin)(pluginRecord.LoadedPlugin ?? pluginRecord.LoadPlugin());
                            dockPanel.ActivatePane();
                        }
                    }

                    break;
            }
            return 0;
        }
    }
}

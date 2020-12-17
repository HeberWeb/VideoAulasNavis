using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Plugins;

namespace NavisPlugin
{
    [Plugin("NavisPlugin", "CONN", DisplayName = "Navis Plugin")]
    public class ClAddin : AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {
            MessageBox.Show("Teste Navis addin", "Execute", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }
    }
}


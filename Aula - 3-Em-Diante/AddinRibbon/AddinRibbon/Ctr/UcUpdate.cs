using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddinRibbon.Ctr
{
    public partial class UcUpdate : UserControl
    {
        public UcUpdate()
        {
            InitializeComponent();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            Dock = DockStyle.Fill;
        }

        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Teste Update", "Teste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

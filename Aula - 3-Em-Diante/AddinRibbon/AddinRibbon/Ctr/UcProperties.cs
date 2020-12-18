using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddinRibbon.Ctr
{
    public partial class UcProperties : UserControl
    {
        public UcProperties()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Aula 6
        /// </summary>
        /// <param name="e"></param>
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Aula 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFind_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}

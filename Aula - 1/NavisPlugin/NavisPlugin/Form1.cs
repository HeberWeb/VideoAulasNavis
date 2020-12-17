using Autodesk.Navisworks.Api.Automation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavisPlugin
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Navis app
        /// </summary>
        public NavisworksApplication NwApp { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartNavis_MouseUp(object sender, MouseEventArgs e)
        {
            //Inicia o Navis
            NwApp = new NavisworksApplication();

            //Define a janela do navis como visível
            NwApp.Visible = true;
        }

        private void btnAppendModel_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                OpenFileDialog dg = new OpenFileDialog();
                if (dg.ShowDialog() == DialogResult.OK)
                {
                    //Append model
                    NwApp.AppendFile(dg.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //Fecha o navis
            NwApp.Dispose();
            base.OnClosing(e);
        }

        private void btnClose_MouseUp(object sender, MouseEventArgs e)
        {
            //Fecha o navis
            NwApp.Dispose();
        }
    }
}

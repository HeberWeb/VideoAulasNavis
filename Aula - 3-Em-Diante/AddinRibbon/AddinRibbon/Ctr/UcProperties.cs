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

            this.ListenSelection(null, null);
            Autodesk.Navisworks.Api.Application.ActiveDocumentChanged += ListenSelection;
        }

        /// <summary>
        /// Aula 6 propriedades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListenSelection(object sender, EventArgs e)
        {
            try
            {
                Autodesk.Navisworks.Api.Application.ActiveDocument.CurrentSelection.Changed += GetProperties;
            }
            catch (Exception)
            {
                return;
            }
            
        }

        /// <summary>
        /// Aula 6 propriedades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetProperties(object sender, EventArgs e)
        {
            this.tbOut.Clear();
            List<string> result = new List<string>();
            //Percorre itens selecionados
            foreach (var item in Autodesk.Navisworks.Api.Application.ActiveDocument.CurrentSelection.SelectedItems)
            {
                result.Add(item.DisplayName);
                //Percorre categorias de propriedades do elementos selecionados
                foreach (var cat in item.PropertyCategories)
                {
                    result.Add(string.Concat(".     ", cat.DisplayName));

                    //Percorre propriedades das categorias dos elementos selecionados
                    foreach (var prop in cat.Properties)
                    {
                        result.Add(string.Concat(".     .       ", prop.DisplayName, "> ", GetPropertyValeu(prop)));
                    }
                }

                result.Add(Environment.NewLine);
            }

            this.tbOut.Text = string.Join(Environment.NewLine, result);
        }

        private string GetPropertyValeu(Autodesk.Navisworks.Api.DataProperty prop)
        {
            return prop.Value.IsDisplayString ? prop.Value.ToDisplayString() : prop.Value.ToString().Split(':')[1];
        }

        /// <summary>
        /// Aula 6 propriedades
        /// </summary>
        /// <param name="e"></param>
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Aula 6 propriedades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFind_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}

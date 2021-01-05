using Autodesk.Navisworks.Api;
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
            if(Autodesk.Navisworks.Api.Application.ActiveDocument != null)
            {
                Autodesk.Navisworks.Api.Application.ActiveDocument.CurrentSelection.Changed += GetProperties;
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
                        result.Add(string.Concat(".     .       ", prop.DisplayName, " > ", GetPropertyValeu(prop)));
                    }
                }

                result.Add(Environment.NewLine);
            }

            this.tbOut.Text = string.Join(Environment.NewLine, result);
        }

        private string GetPropertyValeu(Autodesk.Navisworks.Api.DataProperty prop)
        {
            try
            {
                return prop.Value.IsDisplayString ? prop.Value.ToDisplayString() : prop.Value.ToString().Split(':')[1];
            }
            catch (Exception e)
            {
                return "Erro ao resgatar valor da propriedade (" + e.Message + ")";
            }
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
        /// Aula 6 propriedades e ações na aula 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFind_MouseUp(object sender, MouseEventArgs e)
        {
            List<ModelItem> r = new List<ModelItem>();

            foreach (var item in Autodesk.Navisworks.Api.Application.ActiveDocument.CurrentSelection.SelectedItems)
            {
                var cat = item.DescendantsAndSelf
                    .Where(x => x.PropertyCategories
                        .FindCategoryByDisplayName(this.tbCategoryName.Text) != null);

                var pro = cat
                    .Where(x => x.PropertyCategories
                        .FindCategoryByDisplayName(tbCategoryName.Text)
                        .Properties
                        .FindPropertyByDisplayName(this.tbPropertyName.Text) != null);

                r.AddRange(pro.Where(x => this.GetPropertyValeu(x.PropertyCategories
                        .FindCategoryByDisplayName(tbCategoryName.Text)
                        .Properties
                        .FindPropertyByDisplayName(this.tbPropertyName.Text)) == this.tbPropertyValue.Text));
            }

            Autodesk.Navisworks.Api.Application.ActiveDocument.CurrentSelection.Clear();

            Autodesk.Navisworks.Api.Application.ActiveDocument.CurrentSelection.AddRange(r);
        }

        /// <summary>
        /// Aula 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreateSet_MouseUp(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// Aula 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreateSearch_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}

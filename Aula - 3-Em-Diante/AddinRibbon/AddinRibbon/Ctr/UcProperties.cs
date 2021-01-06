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
using App = Autodesk.Navisworks.Api.Application;

namespace AddinRibbon.Ctr
{
    public partial class UcProperties : UserControl
    {
        public UcProperties()
        {
            InitializeComponent();

            this.ListenSelection(null, null);
            App.ActiveDocumentChanged += ListenSelection;
        }

        /// <summary>
        /// Aula 6 propriedades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListenSelection(object sender, EventArgs e)
        {
            if(App.ActiveDocument != null)
            {
                App.ActiveDocument.CurrentSelection.Changed += GetProperties;
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
            if (!this.cxPause.Checked)
            {
                List<string> result = new List<string>();
                //Percorre itens selecionados
                foreach (var item in App.ActiveDocument.CurrentSelection.SelectedItems)
                {
                    result.Add(string.Concat(".'Item:' ", item.DisplayName));
                    //Percorre categorias de propriedades do elementos selecionados
                    foreach (var cat in item.PropertyCategories)
                    {
                        result.Add(string.Concat(".     'Category:' ", cat.DisplayName));

                        //Percorre propriedades das categorias dos elementos selecionados
                        foreach (var prop in cat.Properties)
                        {
                            result.Add(string.Concat(".     .       'Property:' ", prop.DisplayName, " > ", GetPropertyValeu(prop)));
                        }
                    }

                    result.Add(Environment.NewLine);
                }

                this.tbOut.Text = string.Join(Environment.NewLine, result);
            }
        }

        private string GetPropertyValeu(DataProperty prop)
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

            foreach (var item in App.ActiveDocument.CurrentSelection.SelectedItems)
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

            App.ActiveDocument.CurrentSelection.Clear();

            App.ActiveDocument.CurrentSelection.AddRange(r);
        }

        /// <summary>
        /// Aula 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreateSet_MouseUp(object sender, MouseEventArgs e)
        {
            var ac = App.ActiveDocument;
            var cs = ac.CurrentSelection;
            var se = ac.SelectionSets;

            var fn = "Selection Sets"; //Nome da pasta de set selection
            var sn = Guid.NewGuid().ToString(); //Nome do set selection

            try
            {
                var fi = se.Value.IndexOfDisplayName(fn);
                if (fi == -1)
                {
                    //Cria pasta de sets de seleçao dos itens
                    se.AddCopy(new FolderItem() { DisplayName = fn });
                }

                //Cria seleção dos itens selecionados
                var set = new SelectionSet(cs.SelectedItems) { DisplayName = sn};

                //Insere set de seleção
                se.AddCopy(set);

                var fo = se.Value[se.Value.IndexOfDisplayName(fn)] as FolderItem;
                var ns = se.Value[se.Value.IndexOfDisplayName(fn)] as SavedItem;

                //Move o set para a pasta no indice novo
                se.Move(ns.Parent, se.Value.IndexOfDisplayName(fn), fo, 0);
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Aula 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreateSearch_MouseUp(object sender, MouseEventArgs e)
        {
            var ac = App.ActiveDocument;
            var cs = ac.CurrentSelection;
            var se = ac.SelectionSets;

            var fn = "Search Sets"; //Nome da pasta de set selection
            var sn = Guid.NewGuid().ToString(); //Nome do set selection

            try
            {
                var fi = se.Value.IndexOfDisplayName(fn);
                if (fi == -1)
                {
                    //Cria pasta de sets de seleçao dos itens
                    se.AddCopy(new FolderItem() { DisplayName = fn });
                }

                //Cria seleção dos itens selecionados
                var s = new Search();
                s.Locations = SearchLocations.DescendantsAndSelf;
                s.Selection.SelectAll();

                var sc = SearchCondition.HasPropertyByDisplayName(this.tbCategoryName.Text, this.tbPropertyName.Text);
                s.SearchConditions.Add(sc.EqualValue(VariantData.FromDisplayString(this.tbPropertyValue.Text)));

                var set = new SelectionSet(s) { DisplayName = sn };

                //Insere set de seleção
                se.AddCopy(set);

                var fo = se.Value[se.Value.IndexOfDisplayName(fn)] as FolderItem;
                var ns = se.Value[se.Value.IndexOfDisplayName(fn)] as SavedItem;

                //Move o set para a pasta no indice novo
                se.Move(ns.Parent, se.Value.IndexOfDisplayName(fn), fo, 0);
            }
            catch (Exception ex)
            {
            }
        }
    }
}

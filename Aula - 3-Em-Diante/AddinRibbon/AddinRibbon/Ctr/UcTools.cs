using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NavisworksApp = Autodesk.Navisworks.Api.Application;
using Autodesk.Navisworks.Api.Interop.ComApi;
using Autodesk.Navisworks.Api.ComApi;
using Autodesk.Navisworks.Api;

namespace AddinRibbon.Ctr
{
    /// <summary>
    /// Aula 9 Add referencias Autodesk.Navisworks.ComApi e Autodesk.Navisworks.Interop.ComApi
    /// </summary>
    public partial class UcTools : UserControl
    {
        public ModelItemCollection LastSelection { get; private set; }
        public string LastSelName { get; private set; }

        public UcTools()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Aula 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btIsolateSelection_MouseUp(object sender, MouseEventArgs e)
        {
            this.IsolateSelection();
        }

        /// <summary>
        /// Aula 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSaveViewPoint_MouseUp(object sender, MouseEventArgs e)
        {
            this.SaveCurrentViewPoint();
        }

        /// <summary>
        /// Aula 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btIsolateSaveViewPoint_MouseUp(object sender, MouseEventArgs e)
        {
            this.IsolateSelection();
            this.SaveCurrentViewPoint();
        }

        /// <summary>
        /// Aula 9
        /// </summary>
        private void IsolateSelection()
        {
            var acd = NavisworksApp.ActiveDocument;
            
            //resgata o primeiro elemento selecionado
            var se = acd.CurrentSelection.SelectedItems.First;

            //resgata todos os elementos
            var all = acd.Models.CreateCollectionFromRootItems().SelectMany(x => x.DescendantsAndSelf);

            try
            {
                //Torna visível todos os elementos
                acd.Models.SetHidden(all, false);
                
                //Inverte seleção
                acd.State.InvertSelection();

                //Esconde os elementos selecionados
                acd.Models.SetHidden(acd.CurrentSelection.SelectedItems, true);

                //Modifica orientação da camera
                acd.ActiveView.LookFromFrontRightTop();

                //Salva o nome da seleção atual
                var sel = new ModelItemCollection();
                sel.AddRange(se.DescendantsAndSelf);
                sel.AddRange(se.Ancestors);

                LastSelection = sel;
                LastSelName = se.DisplayName;
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// Aula 9
        /// </summary>
        private void SaveCurrentViewPoint()
        {
            var acd = NavisworksApp.ActiveDocument;

            try
            {
                acd.Models.OverridePermanentColor(LastSelection, new Autodesk.Navisworks.Api.Color(0, 1, 0));
                acd.Models.OverridePermanentTransparency(LastSelection, 0.5);

                var state = ComApiBridge.State;
                var cv = state.CurrentView.Copy();
                var vp = state.ObjectFactory(nwEObjectType.eObjectType_nwOpView);
                var view = vp as InwOpView;

                view.ApplyHideAttribs = true;
                view.ApplyMaterialAttribs = true;

                vp.Name = LastSelName;
                vp.anonview = cv;

                state.SavedViews().Add(vp);
            }
            catch (Exception e)
            {
            }
        }
    }
}

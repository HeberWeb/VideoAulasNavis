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
        /// <summary>
        /// Aula 10
        /// </summary>
        public static Timer TranslateTime { get; } = new Timer() { Enabled = true, Interval = 50 };
        /// <summary>
        /// Aula 10
        /// </summary>
        public static System.Drawing.Color FocusedColor { get; } = System.Drawing.Color.ForestGreen;
        /// <summary>
        /// Aula 9
        /// </summary>
        public ModelItemCollection LastIsolated { get; private set; }
        /// <summary>
        /// Aula 9
        /// </summary>
        public string LastIsolatedName { get; private set; }

        public UcTools()
        {
            InitializeComponent();

            TranslateTime.Tick += Translate;
        }

        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Translate(object sender, EventArgs e)
        {
            if (!MouseButtons.Equals(MouseButtons.Left)) return;
            this.MoveElements();
        }

        private void MoveElements()
        {
            var acd = NavisworksApp.ActiveDocument;

            var x = 0;
            var y = 0;
            var z = 0;
            var inc = 5;
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

                LastIsolated = sel;
                LastIsolatedName = se.DisplayName;
            }
            catch (Exception e)
            {
                //
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
                acd.Models.OverridePermanentColor(LastIsolated, new Autodesk.Navisworks.Api.Color(0, 1, 0));
                acd.Models.OverridePermanentTransparency(LastIsolated, 0.5);

                var state = ComApiBridge.State;
                var cv = state.CurrentView.Copy();
                var vp = state.ObjectFactory(nwEObjectType.eObjectType_nwOpView);
                var view = vp as InwOpView;

                view.ApplyHideAttribs = true;
                view.ApplyMaterialAttribs = true;

                vp.Name = LastIsolatedName;
                vp.anonview = cv;

                state.SavedViews().Add(vp);
            }
            catch (Exception e)
            {
                //
            }
        }

        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEixoYPlus_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEixoYLess_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEixoXPlus_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEixoXLess_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEixoZPlus_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEixoZLess_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btTurnRigth_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btTurnLeft_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReset_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}

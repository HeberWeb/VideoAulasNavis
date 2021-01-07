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
using Autodesk.Navisworks.Api.Clash;

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
        public static System.Drawing.Color FocusedColor { get; } = System.Drawing.Color.SkyBlue;
       
        /// <summary>
        /// Aula 10
        /// </summary>
        public static System.Drawing.Color UnFocusedColor { get; } = Button.DefaultBackColor;
        
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

            //Aula 10
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

            this.RotateElements();

            if (LbReset.BackColor.Equals(FocusedColor))
            {
                try
                {
                    var acd = NavisworksApp.ActiveDocument;
                    var se = acd.CurrentSelection.SelectedItems;
                    acd.Models.ResetPermanentTransform(se);

                    this.lbCenterLogEixos.Text = string.Format("X = {0}\n Y = {1}\n Z = {2}", se.BoundingBox().Center.X.ToString(),
                    se.BoundingBox().Center.Y.ToString(),
                    se.BoundingBox().Center.Z.ToString());
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        /// <summary>
        /// Aula 10
        /// </summary>
        private void RotateElements()
        {
            var acd = NavisworksApp.ActiveDocument;

            double a = 0;
            double inc = 3;

            if (LbTurnRigth.BackColor.Equals(FocusedColor))
            {
                a = inc * (Math.PI / 180.0);
            }

            if (LbTurnLeft.BackColor.Equals(FocusedColor))
            {
                a = -inc * (Math.PI / 180.0);
            }

            if (a == 0) return;

            try
            {
                var se = acd.CurrentSelection.SelectedItems;

                foreach (var item in se)
                {
                    var loc = item.BoundingBox().Center;

                    var mb = new Vector3D(loc.X, loc.Y, loc.Z);

                    var mo = new Vector3D(-loc.X, -loc.Y, -loc.Z);

                    var transVec = Transform3D.CreateTranslation(mo);

                    acd.Models.OverridePermanentTransform(new List<ModelItem> { item }, transVec, true);

                    //Rotate
                    var rt = new Rotation3D(new UnitVector3D(0, 0, 1), a);

                    var transRotate = new Transform3D(rt, mb);

                    acd.Models.OverridePermanentTransform(new List<ModelItem> { item }, transRotate, true);

                    this.lbCenterLogEixos.Text = string.Format("X = {0}\n Y = {1}\n Z = {2}", item.BoundingBox().Center.X.ToString(),
                    item.BoundingBox().Center.Y.ToString(),
                    item.BoundingBox().Center.Z.ToString());
                }
            }
            catch (Exception)
            {
                //
            }
        }

        /// <summary>
        /// Aula 10
        /// </summary>
        private void MoveElements()
        {
            var acd = NavisworksApp.ActiveDocument;

            var x = 0;
            var y = 0;
            var z = 0;
            var inc = 10;

            if (LbEixoXPlus.BackColor.Equals(FocusedColor))
            {
                x = inc;
            }

            if (LbEixoXLess.BackColor.Equals(FocusedColor))
            {
                x = -inc;
            }

            if (LbEixoYPlus.BackColor.Equals(FocusedColor))
            {
                y = inc;
            }

            if (LbEixoYLess.BackColor.Equals(FocusedColor))
            {
                y = -inc;
            }

            if (LbEixoZPlus.BackColor.Equals(FocusedColor))
            {
                z = inc;
            }

            if (LbEixoZLess.BackColor.Equals(FocusedColor))
            {
                z = -inc;
            }

            if (x == 0 && y == 0 && z == 0) return;

            try
            {
                var se = acd.CurrentSelection.SelectedItems;

                foreach (var item in se)
                {
                    var im = item.AncestorsAndSelf.First(i => i.Model != null);

                    var sc = UnitConversion.ScaleFactor(Units.Millimeters, im.Model.Units);

                    var mv = new Vector3D(x * sc, y * sc, z * sc);

                    var transVec = Transform3D.CreateTranslation(mv);

                    acd.Models.OverridePermanentTransform(new List<ModelItem> { item }, transVec, true);

                    this.lbCenterLogEixos.Text = string.Format("X = {0}\n Y = {1}\n Z = {2}", item.BoundingBox().Center.X.ToString(),
                    item.BoundingBox().Center.Y.ToString(),
                    item.BoundingBox().Center.Z.ToString());
                }
            }
            catch (Exception)
            {
                //
            }
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
        /// Aula 11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbCkeck_MouseUp(object sender, MouseEventArgs e)
        {
            var acd = NavisworksApp.ActiveDocument;
            var allItems = new ModelItemCollection();

            allItems.AddRange(acd.CurrentSelection.SelectedItems);

            var cb = new ModelItemCollection();

            foreach (var modelItem in allItems)
            {
                cb.Clear();
                cb.AddRange(allItems);
                cb.Remove(modelItem);

                // Cria o teste de clash
                var ct = new ClashTest { CustomTestName = modelItem.DisplayName };
                ct.DisplayName = ct.CustomTestName;

                ct.TestType = ClashTestType.Hard;

                //Scala de conversão
                var sc = UnitConversion.ScaleFactor(acd.Models.First.Units, Units.Millimeters);
                ct.Tolerance = Convert.ToDouble(1 / sc);

                ct.SelectionA.SelfIntersect = false;
                ct.SelectionA.PrimitiveTypes = PrimitiveTypes.Triangles;
                ct.SelectionB.SelfIntersect = false;
                ct.SelectionB.PrimitiveTypes = PrimitiveTypes.Triangles;

                ct.SelectionA.Selection.CopyFrom(new ModelItemCollection() { modelItem });
                ct.SelectionB.Selection.CopyFrom(cb);

                try
                {
                    var dc = acd.Clash as DocumentClash;
                    var tcopy = (ClashTest)ct.CreateCopy();
                    dc.TestsData.TestsAddCopy(tcopy);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbFocused(object sender, EventArgs e)
        {
            (sender as Label).BackColor = FocusedColor;
        }

        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbUnfocused(object sender, EventArgs e)
        {
            (sender as Label).BackColor = UnFocusedColor;
        }

        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLbFixSing(object sender, MouseEventArgs e)
        {
            (sender as Label).BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// Aula 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLbFix3d(object sender, MouseEventArgs e)
        {
            (sender as Label).BorderStyle = BorderStyle.Fixed3D;
        }
    }
}

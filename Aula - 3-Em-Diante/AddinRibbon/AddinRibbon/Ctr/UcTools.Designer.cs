
using System;
using System.Windows.Forms;

namespace AddinRibbon.Ctr
{
    partial class UcTools
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btIsolateSelection = new System.Windows.Forms.Button();
            this.btSaveViewPoint = new System.Windows.Forms.Button();
            this.btIsolateSaveViewPoint = new System.Windows.Forms.Button();
            this.lbCenterDirectional = new System.Windows.Forms.Label();
            this.LbEixoYPlus = new System.Windows.Forms.Label();
            this.LbEixoYLess = new System.Windows.Forms.Label();
            this.LbEixoXPlus = new System.Windows.Forms.Label();
            this.LbEixoXLess = new System.Windows.Forms.Label();
            this.LbReset = new System.Windows.Forms.Label();
            this.LbEixoZPlus = new System.Windows.Forms.Label();
            this.LbEixoZLess = new System.Windows.Forms.Label();
            this.LbTurnRigth = new System.Windows.Forms.Label();
            this.LbTurnLeft = new System.Windows.Forms.Label();
            this.lbCenterLogEixos = new System.Windows.Forms.Label();
            this.lbCheckSelection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btIsolateSelection
            // 
            this.btIsolateSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btIsolateSelection.Location = new System.Drawing.Point(4, 4);
            this.btIsolateSelection.Name = "btIsolateSelection";
            this.btIsolateSelection.Size = new System.Drawing.Size(282, 29);
            this.btIsolateSelection.TabIndex = 0;
            this.btIsolateSelection.Text = "Isolate Selection";
            this.btIsolateSelection.UseVisualStyleBackColor = true;
            this.btIsolateSelection.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btIsolateSelection_MouseUp);
            // 
            // btSaveViewPoint
            // 
            this.btSaveViewPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveViewPoint.Location = new System.Drawing.Point(4, 39);
            this.btSaveViewPoint.Name = "btSaveViewPoint";
            this.btSaveViewPoint.Size = new System.Drawing.Size(282, 29);
            this.btSaveViewPoint.TabIndex = 1;
            this.btSaveViewPoint.Text = "Save Viewpoint";
            this.btSaveViewPoint.UseVisualStyleBackColor = true;
            this.btSaveViewPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btSaveViewPoint_MouseUp);
            // 
            // btIsolateSaveViewPoint
            // 
            this.btIsolateSaveViewPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btIsolateSaveViewPoint.Location = new System.Drawing.Point(3, 74);
            this.btIsolateSaveViewPoint.Name = "btIsolateSaveViewPoint";
            this.btIsolateSaveViewPoint.Size = new System.Drawing.Size(282, 29);
            this.btIsolateSaveViewPoint.TabIndex = 2;
            this.btIsolateSaveViewPoint.Text = "Isolate and save Viewpoint";
            this.btIsolateSaveViewPoint.UseVisualStyleBackColor = true;
            this.btIsolateSaveViewPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btIsolateSaveViewPoint_MouseUp);
            // 
            // lbCenterDirectional
            // 
            this.lbCenterDirectional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCenterDirectional.Location = new System.Drawing.Point(50, 151);
            this.lbCenterDirectional.Name = "lbCenterDirectional";
            this.lbCenterDirectional.Size = new System.Drawing.Size(40, 40);
            this.lbCenterDirectional.TabIndex = 7;
            this.lbCenterDirectional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbEixoYPlus
            // 
            this.LbEixoYPlus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbEixoYPlus.Location = new System.Drawing.Point(50, 106);
            this.LbEixoYPlus.Name = "LbEixoYPlus";
            this.LbEixoYPlus.Size = new System.Drawing.Size(40, 40);
            this.LbEixoYPlus.TabIndex = 3;
            this.LbEixoYPlus.Text = "Y+";
            this.LbEixoYPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbEixoYPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnLbFix3d);
            this.LbEixoYPlus.MouseLeave += new System.EventHandler(this.LbUnfocused);
            this.LbEixoYPlus.MouseHover += new System.EventHandler(this.LbFocused);
            this.LbEixoYPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnLbFixSing);
            // 
            // LbEixoYLess
            // 
            this.LbEixoYLess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbEixoYLess.Location = new System.Drawing.Point(50, 195);
            this.LbEixoYLess.Name = "LbEixoYLess";
            this.LbEixoYLess.Size = new System.Drawing.Size(40, 40);
            this.LbEixoYLess.TabIndex = 4;
            this.LbEixoYLess.Text = "Y-";
            this.LbEixoYLess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbEixoYLess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnLbFix3d);
            this.LbEixoYLess.MouseLeave += new System.EventHandler(this.LbUnfocused);
            this.LbEixoYLess.MouseHover += new System.EventHandler(this.LbFocused);
            this.LbEixoYLess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnLbFixSing);
            // 
            // LbEixoXPlus
            // 
            this.LbEixoXPlus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbEixoXPlus.Location = new System.Drawing.Point(96, 151);
            this.LbEixoXPlus.Name = "LbEixoXPlus";
            this.LbEixoXPlus.Size = new System.Drawing.Size(40, 40);
            this.LbEixoXPlus.TabIndex = 5;
            this.LbEixoXPlus.Text = "X+";
            this.LbEixoXPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbEixoXPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnLbFix3d);
            this.LbEixoXPlus.MouseLeave += new System.EventHandler(this.LbUnfocused);
            this.LbEixoXPlus.MouseHover += new System.EventHandler(this.LbFocused);
            this.LbEixoXPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnLbFixSing);
            // 
            // LbEixoXLess
            // 
            this.LbEixoXLess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbEixoXLess.Location = new System.Drawing.Point(4, 151);
            this.LbEixoXLess.Name = "LbEixoXLess";
            this.LbEixoXLess.Size = new System.Drawing.Size(40, 40);
            this.LbEixoXLess.TabIndex = 6;
            this.LbEixoXLess.Text = "X-";
            this.LbEixoXLess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbEixoXLess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnLbFix3d);
            this.LbEixoXLess.MouseLeave += new System.EventHandler(this.LbUnfocused);
            this.LbEixoXLess.MouseHover += new System.EventHandler(this.LbFocused);
            this.LbEixoXLess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnLbFixSing);
            // 
            // LbReset
            // 
            this.LbReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbReset.Location = new System.Drawing.Point(142, 152);
            this.LbReset.Name = "LbReset";
            this.LbReset.Size = new System.Drawing.Size(143, 40);
            this.LbReset.TabIndex = 8;
            this.LbReset.Text = "Reset";
            this.LbReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnLbFix3d);
            this.LbReset.MouseLeave += new System.EventHandler(this.LbUnfocused);
            this.LbReset.MouseHover += new System.EventHandler(this.LbFocused);
            this.LbReset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnLbFixSing);
            // 
            // LbEixoZPlus
            // 
            this.LbEixoZPlus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbEixoZPlus.Location = new System.Drawing.Point(142, 109);
            this.LbEixoZPlus.Name = "LbEixoZPlus";
            this.LbEixoZPlus.Size = new System.Drawing.Size(40, 40);
            this.LbEixoZPlus.TabIndex = 9;
            this.LbEixoZPlus.Text = "Z+";
            this.LbEixoZPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbEixoZPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnLbFix3d);
            this.LbEixoZPlus.MouseLeave += new System.EventHandler(this.LbUnfocused);
            this.LbEixoZPlus.MouseHover += new System.EventHandler(this.LbFocused);
            this.LbEixoZPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnLbFixSing);
            // 
            // LbEixoZLess
            // 
            this.LbEixoZLess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbEixoZLess.Location = new System.Drawing.Point(142, 195);
            this.LbEixoZLess.Name = "LbEixoZLess";
            this.LbEixoZLess.Size = new System.Drawing.Size(40, 40);
            this.LbEixoZLess.TabIndex = 10;
            this.LbEixoZLess.Text = "Z-";
            this.LbEixoZLess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbEixoZLess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnLbFix3d);
            this.LbEixoZLess.MouseLeave += new System.EventHandler(this.LbUnfocused);
            this.LbEixoZLess.MouseHover += new System.EventHandler(this.LbFocused);
            this.LbEixoZLess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnLbFixSing);
            // 
            // LbTurnRigth
            // 
            this.LbTurnRigth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbTurnRigth.Location = new System.Drawing.Point(188, 109);
            this.LbTurnRigth.Name = "LbTurnRigth";
            this.LbTurnRigth.Size = new System.Drawing.Size(97, 40);
            this.LbTurnRigth.TabIndex = 11;
            this.LbTurnRigth.Text = "Turn Rigth";
            this.LbTurnRigth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbTurnRigth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnLbFix3d);
            this.LbTurnRigth.MouseLeave += new System.EventHandler(this.LbUnfocused);
            this.LbTurnRigth.MouseHover += new System.EventHandler(this.LbFocused);
            this.LbTurnRigth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnLbFixSing);
            // 
            // LbTurnLeft
            // 
            this.LbTurnLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbTurnLeft.Location = new System.Drawing.Point(188, 195);
            this.LbTurnLeft.Name = "LbTurnLeft";
            this.LbTurnLeft.Size = new System.Drawing.Size(97, 40);
            this.LbTurnLeft.TabIndex = 12;
            this.LbTurnLeft.Text = "Turn Left";
            this.LbTurnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbTurnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnLbFix3d);
            this.LbTurnLeft.MouseLeave += new System.EventHandler(this.LbUnfocused);
            this.LbTurnLeft.MouseHover += new System.EventHandler(this.LbFocused);
            this.LbTurnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnLbFixSing);
            // 
            // lbCenterLogEixos
            // 
            this.lbCenterLogEixos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCenterLogEixos.Location = new System.Drawing.Point(4, 246);
            this.lbCenterLogEixos.Name = "lbCenterLogEixos";
            this.lbCenterLogEixos.Size = new System.Drawing.Size(281, 140);
            this.lbCenterLogEixos.TabIndex = 13;
            this.lbCenterLogEixos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCheckSelection
            // 
            this.lbCheckSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCheckSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCheckSelection.Location = new System.Drawing.Point(4, 398);
            this.lbCheckSelection.Name = "lbCheckSelection";
            this.lbCheckSelection.Size = new System.Drawing.Size(281, 40);
            this.lbCheckSelection.TabIndex = 14;
            this.lbCheckSelection.Text = "Check Selection";
            this.lbCheckSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCheckSelection.MouseLeave += new System.EventHandler(this.LbUnfocused);
            this.lbCheckSelection.MouseHover += new System.EventHandler(this.LbFocused);
            this.lbCheckSelection.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbCkeck_MouseUp);
            // 
            // UcTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCheckSelection);
            this.Controls.Add(this.lbCenterLogEixos);
            this.Controls.Add(this.LbTurnLeft);
            this.Controls.Add(this.LbTurnRigth);
            this.Controls.Add(this.LbEixoZLess);
            this.Controls.Add(this.LbEixoZPlus);
            this.Controls.Add(this.LbReset);
            this.Controls.Add(this.lbCenterDirectional);
            this.Controls.Add(this.LbEixoXLess);
            this.Controls.Add(this.LbEixoXPlus);
            this.Controls.Add(this.LbEixoYLess);
            this.Controls.Add(this.LbEixoYPlus);
            this.Controls.Add(this.btIsolateSaveViewPoint);
            this.Controls.Add(this.btSaveViewPoint);
            this.Controls.Add(this.btIsolateSelection);
            this.Name = "UcTools";
            this.Size = new System.Drawing.Size(289, 438);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIsolateSelection;
        private System.Windows.Forms.Button btSaveViewPoint;
        private System.Windows.Forms.Button btIsolateSaveViewPoint;
        private System.Windows.Forms.Label LbEixoYPlus;
        private System.Windows.Forms.Label LbEixoYLess;
        private System.Windows.Forms.Label LbEixoXPlus;
        private System.Windows.Forms.Label LbEixoXLess;
        private System.Windows.Forms.Label lbCenterDirectional;
        private System.Windows.Forms.Label LbReset;
        private System.Windows.Forms.Label LbEixoZPlus;
        private System.Windows.Forms.Label LbEixoZLess;
        private System.Windows.Forms.Label LbTurnRigth;
        private System.Windows.Forms.Label LbTurnLeft;
        private Label lbCenterLogEixos;
        private Label lbCheckSelection;
    }
}

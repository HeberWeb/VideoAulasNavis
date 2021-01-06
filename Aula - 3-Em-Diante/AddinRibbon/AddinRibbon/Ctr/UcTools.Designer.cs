
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
            // UcTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}

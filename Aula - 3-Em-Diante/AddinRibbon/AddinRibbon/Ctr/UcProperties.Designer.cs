
namespace AddinRibbon.Ctr
{
    partial class UcProperties
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
            this.tbOut = new System.Windows.Forms.TextBox();
            this.lbCatogoryName = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.tbPropertyName = new System.Windows.Forms.TextBox();
            this.lbPropertyName = new System.Windows.Forms.Label();
            this.tbPropertyValue = new System.Windows.Forms.TextBox();
            this.lbPropertyValue = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOut
            // 
            this.tbOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOut.Location = new System.Drawing.Point(4, 4);
            this.tbOut.Margin = new System.Windows.Forms.Padding(5);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOut.Size = new System.Drawing.Size(282, 330);
            this.tbOut.TabIndex = 0;
            // 
            // lbCatogoryName
            // 
            this.lbCatogoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCatogoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCatogoryName.Location = new System.Drawing.Point(3, 339);
            this.lbCatogoryName.Name = "lbCatogoryName";
            this.lbCatogoryName.Size = new System.Drawing.Size(108, 20);
            this.lbCatogoryName.TabIndex = 1;
            this.lbCatogoryName.Text = "Category Name";
            this.lbCatogoryName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCategoryName.Location = new System.Drawing.Point(117, 339);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(169, 20);
            this.tbCategoryName.TabIndex = 2;
            // 
            // tbPropertyName
            // 
            this.tbPropertyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPropertyName.Location = new System.Drawing.Point(117, 365);
            this.tbPropertyName.Name = "tbPropertyName";
            this.tbPropertyName.Size = new System.Drawing.Size(169, 20);
            this.tbPropertyName.TabIndex = 4;
            // 
            // lbPropertyName
            // 
            this.lbPropertyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPropertyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPropertyName.Location = new System.Drawing.Point(3, 365);
            this.lbPropertyName.Name = "lbPropertyName";
            this.lbPropertyName.Size = new System.Drawing.Size(108, 20);
            this.lbPropertyName.TabIndex = 3;
            this.lbPropertyName.Text = "Property Name";
            this.lbPropertyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPropertyValue
            // 
            this.tbPropertyValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPropertyValue.Location = new System.Drawing.Point(117, 391);
            this.tbPropertyValue.Name = "tbPropertyValue";
            this.tbPropertyValue.Size = new System.Drawing.Size(169, 20);
            this.tbPropertyValue.TabIndex = 6;
            // 
            // lbPropertyValue
            // 
            this.lbPropertyValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPropertyValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPropertyValue.Location = new System.Drawing.Point(3, 391);
            this.lbPropertyValue.Name = "lbPropertyValue";
            this.lbPropertyValue.Size = new System.Drawing.Size(108, 20);
            this.lbPropertyValue.TabIndex = 5;
            this.lbPropertyValue.Text = "Property Value";
            this.lbPropertyValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btFind
            // 
            this.btFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFind.Location = new System.Drawing.Point(0, 415);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(289, 23);
            this.btFind.TabIndex = 7;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btFind_MouseUp);
            // 
            // UcProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.tbPropertyValue);
            this.Controls.Add(this.lbPropertyValue);
            this.Controls.Add(this.tbPropertyName);
            this.Controls.Add(this.lbPropertyName);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.lbCatogoryName);
            this.Controls.Add(this.tbOut);
            this.Name = "UcProperties";
            this.Size = new System.Drawing.Size(289, 438);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Label lbCatogoryName;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.TextBox tbPropertyName;
        private System.Windows.Forms.Label lbPropertyName;
        private System.Windows.Forms.TextBox tbPropertyValue;
        private System.Windows.Forms.Label lbPropertyValue;
        private System.Windows.Forms.Button btFind;
    }
}

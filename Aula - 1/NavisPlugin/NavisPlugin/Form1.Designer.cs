namespace NavisPlugin
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartNavis = new System.Windows.Forms.Button();
            this.btnAppendModel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartNavis
            // 
            this.btnStartNavis.Location = new System.Drawing.Point(12, 12);
            this.btnStartNavis.Name = "btnStartNavis";
            this.btnStartNavis.Size = new System.Drawing.Size(205, 23);
            this.btnStartNavis.TabIndex = 0;
            this.btnStartNavis.Text = "StartNavisworks";
            this.btnStartNavis.UseVisualStyleBackColor = true;
            this.btnStartNavis.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStartNavis_MouseUp);
            // 
            // btnAppendModel
            // 
            this.btnAppendModel.Location = new System.Drawing.Point(12, 41);
            this.btnAppendModel.Name = "btnAppendModel";
            this.btnAppendModel.Size = new System.Drawing.Size(205, 23);
            this.btnAppendModel.TabIndex = 1;
            this.btnAppendModel.Text = "AppendModel";
            this.btnAppendModel.UseVisualStyleBackColor = true;
            this.btnAppendModel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAppendModel_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 70);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(205, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 122);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAppendModel);
            this.Controls.Add(this.btnStartNavis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartNavis;
        private System.Windows.Forms.Button btnAppendModel;
        private System.Windows.Forms.Button btnClose;
    }
}


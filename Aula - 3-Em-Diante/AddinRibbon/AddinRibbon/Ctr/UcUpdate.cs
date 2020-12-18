using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AddinRibbon.Ctr
{
    public partial class UcUpdate : UserControl
    {
        public Timer UpTimer = new Timer() { Enabled = true, Interval = 1000 };

        public List<FileInfo> ListInfos = new List<FileInfo>();
 
        /// <summary>
        /// Aula 4 e 5
        /// </summary>
        public UcUpdate()
        {
            InitializeComponent();
            this.btnUpdate.Enabled = false;

            UpTimer.Tick += UpTimer_Tick;

            this.tbLog.AppendText(string.Concat("Monitoring Models...",
                            Environment.NewLine));

            Autodesk.Navisworks.Api.Application.ActiveDocumentChanged += Application_ActiveDocumentChanged;
        }

        /// <summary>
        /// Aula 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_ActiveDocumentChanged(object sender, EventArgs e)
        {
            ListInfos.Clear();
        }

        /// <summary>
        /// Aula 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpTimer_Tick(object sender, EventArgs e)
        {
            if (this.cbPause.Checked) return;

            if (Autodesk.Navisworks.Api.Application.ActiveDocument == null) return;

            var activeDocument = Autodesk.Navisworks.Api.Application.ActiveDocument;

            foreach (var model in activeDocument.Models)
            {
                FileInfo currentInfo = new FileInfo(model.SourceFileName);

                var lastInfo = ListInfos.FirstOrDefault(x => x.FullName == currentInfo.FullName);
                if (lastInfo != null)
                {
                    var time = Math.Abs((lastInfo.LastWriteTime - currentInfo.LastWriteTime).TotalSeconds);
                    if (time > 1)
                    {
                        ListInfos.Remove(lastInfo);
                        ListInfos.Add(currentInfo);

                        this.tbLog.AppendText(string.Concat(currentInfo.Name,
                            "was update", 
                            Environment.NewLine));

                        if (this.autoUpdate.Checked)
                        {
                            this.UpdateModel();
                        }
                        else
                        {
                            btnUpdate.Enabled = true;
                        }
                    }
                }
                else
                {
                    ListInfos.Add(currentInfo);
                }
            }
        }

        /// <summary>
        /// Aula 5
        /// </summary>
        private void UpdateModel()
        {
            Autodesk.Navisworks.Api.Application.ActiveDocument.UpdateFiles();
            this.tbLog.AppendText(string.Concat("The active document was update!",
                            Environment.NewLine));
            btnUpdate.Enabled = false;
        }

        /// <summary>
        /// Aula 3
        /// </summary>
        /// <param name="e"></param>
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Aula 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateModel();
        }

        /// <summary>
        /// Aula 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearLog_MouseUp(object sender, MouseEventArgs e)
        {
            this.tbLog.Clear();
            this.tbLog.AppendText(string.Concat("Monitoring Models...",
                Environment.NewLine));
        }
    }
}

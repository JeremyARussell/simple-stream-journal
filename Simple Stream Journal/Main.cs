using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Simple_Stream_Journal
{
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

        }

        private void Main_Shown(object sender, EventArgs e) {
            timeSinceLastChange = 0;
            needsSaved = false;

            startDateTime = new DateTime();
            hasStartDateTime = false;

            Open();
            NameTitle();
        }

        private int timeSinceLastChange;
        private bool needsSaved;

        private DateTime startDateTime;
        private bool hasStartDateTime;

        private void Save() {
            var Filename = "Journal.txt";
            var Content =   controlOldContentTextBox.Text +
                            Environment.NewLine + 
                            "-Start-" + startDateTime.ToString("---yyyy-MM-dd-HH:mm:ss-") +
                            Environment.NewLine +
                            controlCurrentContentTextBox.Text +
                            Environment.NewLine +
                            "-Finish-" + DateTime.Now.AddSeconds(-7).ToString("---yyyy-MM-dd-HH:mm:ss---") +
                            Environment.NewLine + 
                            "==============================================";

            File.WriteAllText(Filename, Content);

            Open();

            controlCurrentContentTextBox.Text = "";

            needsSaved = false;
            hasStartDateTime = false;
        }

        private void Open() {
            var Filename = "Journal.txt";

            if (!File.Exists(Filename)) {
                File.WriteAllText(Filename, "");
            }

            using (var FileStream = new FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
                using (var StreamReader = new StreamReader(FileStream, Encoding.ASCII, false)) {
                    var text = StreamReader.ReadToEnd();
                    controlOldContentTextBox.Text = text;
                    controlOldContentTextBox.SelectionStart = controlOldContentTextBox.Text.Length;
                    controlOldContentTextBox.ScrollToCaret();
                    controlOldContentTextBox.SelectionStart = 0;
                    controlOldContentTextBox.SelectionLength = 0;
                }
            }
        }

        private void NameTitle() {
            var folderName = Directory.GetCurrentDirectory().Split(Path.DirectorySeparatorChar).Last();
            Text = "Stream Journal - " + folderName;
        }

        private void controlStampTimer_Tick(object sender, EventArgs e) {
            timeSinceLastChange++;

            if (timeSinceLastChange > 6) {
                Save();
                controlStampTimer.Enabled = false;
            }
        }

        private void controlCurrentContentTextBox_TextChanged(object sender, EventArgs e) {
            timeSinceLastChange = 0;
            needsSaved = true;
            controlStampTimer.Enabled = true;
            if(!hasStartDateTime) {
                hasStartDateTime = true;
                startDateTime = DateTime.Now;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = needsSaved;
        }

    }
}

namespace Simple_Stream_Journal
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.controlOldContentTextBox = new System.Windows.Forms.TextBox();
            this.controlCurrentContentTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.controlStampTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlOldContentTextBox
            // 
            this.controlOldContentTextBox.AcceptsReturn = true;
            this.controlOldContentTextBox.AcceptsTab = true;
            this.controlOldContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlOldContentTextBox.HideSelection = false;
            this.controlOldContentTextBox.Location = new System.Drawing.Point(0, 0);
            this.controlOldContentTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlOldContentTextBox.Multiline = true;
            this.controlOldContentTextBox.Name = "controlOldContentTextBox";
            this.controlOldContentTextBox.ReadOnly = true;
            this.controlOldContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.controlOldContentTextBox.Size = new System.Drawing.Size(1008, 530);
            this.controlOldContentTextBox.TabIndex = 0;
            // 
            // controlCurrentContentTextBox
            // 
            this.controlCurrentContentTextBox.AcceptsReturn = true;
            this.controlCurrentContentTextBox.AcceptsTab = true;
            this.controlCurrentContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlCurrentContentTextBox.HideSelection = false;
            this.controlCurrentContentTextBox.Location = new System.Drawing.Point(0, 0);
            this.controlCurrentContentTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlCurrentContentTextBox.Multiline = true;
            this.controlCurrentContentTextBox.Name = "controlCurrentContentTextBox";
            this.controlCurrentContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.controlCurrentContentTextBox.Size = new System.Drawing.Size(1008, 201);
            this.controlCurrentContentTextBox.TabIndex = 1;
            this.controlCurrentContentTextBox.TextChanged += new System.EventHandler(this.controlCurrentContentTextBox_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.controlOldContentTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.controlCurrentContentTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 737);
            this.splitContainer1.SplitterDistance = 530;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // controlStampTimer
            // 
            this.controlStampTimer.Interval = 1000;
            this.controlStampTimer.Tick += new System.EventHandler(this.controlStampTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 737);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Simple Stream Journal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox controlOldContentTextBox;
        private System.Windows.Forms.TextBox controlCurrentContentTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer controlStampTimer;
    }
}


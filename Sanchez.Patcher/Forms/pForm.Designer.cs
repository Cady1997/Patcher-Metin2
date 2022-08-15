namespace MT2.Patcher
{
    partial class pForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.completeProgress = new System.Windows.Forms.ProgressBar();
            this.currentProgress = new System.Windows.Forms.ProgressBar();
            this.completeProgressText = new System.Windows.Forms.Label();
            this.currentProgressText = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip.Location = new System.Drawing.Point(0, 148);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(460, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "Status";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            // 
            // completeProgress
            // 
            this.completeProgress.Location = new System.Drawing.Point(12, 25);
            this.completeProgress.Name = "completeProgress";
            this.completeProgress.Size = new System.Drawing.Size(436, 21);
            this.completeProgress.TabIndex = 1;
            this.completeProgress.Click += new System.EventHandler(this.completeProgress_Click);
            // 
            // currentProgress
            // 
            this.currentProgress.Location = new System.Drawing.Point(12, 65);
            this.currentProgress.Name = "currentProgress";
            this.currentProgress.Size = new System.Drawing.Size(436, 21);
            this.currentProgress.TabIndex = 2;
            // 
            // completeProgressText
            // 
            this.completeProgressText.AutoSize = true;
            this.completeProgressText.Location = new System.Drawing.Point(9, 9);
            this.completeProgressText.Name = "completeProgressText";
            this.completeProgressText.Size = new System.Drawing.Size(110, 13);
            this.completeProgressText.TabIndex = 3;
            this.completeProgressText.Text = "Postęp Całkowity: 0%";
            // 
            // currentProgressText
            // 
            this.currentProgressText.AutoSize = true;
            this.currentProgressText.Location = new System.Drawing.Point(9, 49);
            this.currentProgressText.Name = "currentProgressText";
            this.currentProgressText.Size = new System.Drawing.Size(145, 13);
            this.currentProgressText.TabIndex = 4;
            this.currentProgressText.Text = "Postęp pliku: 0%  |  0.00 kb/s";
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(12, 109);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(436, 23);
            this.Start.TabIndex = 5;
            this.Start.Text = "Uruchom Klienta";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pandorum.pl";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(363, 155);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(46, 13);
            this.version.TabIndex = 8;
            this.version.Text = "v1.2.3.4";
            this.version.Click += new System.EventHandler(this.label2_Click);
            // 
            // pForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 170);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.currentProgressText);
            this.Controls.Add(this.completeProgressText);
            this.Controls.Add(this.currentProgress);
            this.Controls.Add(this.completeProgress);
            this.Controls.Add(this.statusStrip);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(476, 209);
            this.MinimumSize = new System.Drawing.Size(476, 209);
            this.Name = "pForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pandorum.pl - Aktualizacja";
            this.Shown += new System.EventHandler(this.pForm_Shown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        public  System.Windows.Forms.ToolStripStatusLabel Status;
        public  System.Windows.Forms.ProgressBar completeProgress;
        public  System.Windows.Forms.ProgressBar currentProgress;
        public  System.Windows.Forms.Label completeProgressText;
        public  System.Windows.Forms.Label currentProgressText;
        public  System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label version;
    }
}


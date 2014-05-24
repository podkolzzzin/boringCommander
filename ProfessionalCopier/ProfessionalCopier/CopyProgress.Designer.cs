namespace PC
{
    partial class CopyProgress
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.source = new System.Windows.Forms.Label();
            this.dest = new System.Windows.Forms.Label();
            this.numFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(687, 225);
            this.progressBar1.TabIndex = 0;
            // 
            // source
            // 
            this.source.AutoSize = true;
            this.source.Location = new System.Drawing.Point(12, 240);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(58, 13);
            this.source.TabIndex = 1;
            this.source.Text = "Источник:";
            // 
            // dest
            // 
            this.dest.AutoSize = true;
            this.dest.Location = new System.Drawing.Point(12, 257);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(39, 13);
            this.dest.TabIndex = 2;
            this.dest.Text = "Цель: ";
            // 
            // numFiles
            // 
            this.numFiles.AutoSize = true;
            this.numFiles.Location = new System.Drawing.Point(12, 275);
            this.numFiles.Name = "numFiles";
            this.numFiles.Size = new System.Drawing.Size(81, 13);
            this.numFiles.TabIndex = 3;
            this.numFiles.Text = "Всего файлов:";
            // 
            // CopyProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 362);
            this.Controls.Add(this.numFiles);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.source);
            this.Controls.Add(this.progressBar1);
            this.Name = "CopyProgress";
            this.Text = "CopyProgress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label source;
        public System.Windows.Forms.Label dest;
        public System.Windows.Forms.Label numFiles;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}
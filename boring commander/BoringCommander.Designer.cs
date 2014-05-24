namespace boring_commander
{
    partial class BoringCommander
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._left = new System.Windows.Forms.ListView();
            this._nameHeaderL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._extensionHeaderL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._sizeHeaderL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._right = new System.Windows.Forms.ListView();
            this._nameHeaderR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._extensionHeaderR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._sizeHeaderR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.историяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.свойстваToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьToolStripMenuItem,
            this.отобразитьToolStripMenuItem});
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.историяToolStripMenuItem.Text = "История";
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.показатьToolStripMenuItem.Text = "Показать";
            this.показатьToolStripMenuItem.Click += new System.EventHandler(this.показатьToolStripMenuItem_Click);
            // 
            // отобразитьToolStripMenuItem
            // 
            this.отобразитьToolStripMenuItem.Name = "отобразитьToolStripMenuItem";
            this.отобразитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.Delete)));
            this.отобразитьToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.отобразитьToolStripMenuItem.Text = "Удалить";
            this.отобразитьToolStripMenuItem.Click += new System.EventHandler(this.отобразитьToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._left);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._right);
            this.splitContainer1.Size = new System.Drawing.Size(799, 563);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 1;
            // 
            // _left
            // 
            this._left.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._nameHeaderL,
            this._extensionHeaderL,
            this._sizeHeaderL});
            this._left.Dock = System.Windows.Forms.DockStyle.Fill;
            this._left.Location = new System.Drawing.Point(0, 0);
            this._left.Name = "_left";
            this._left.Size = new System.Drawing.Size(396, 563);
            this._left.TabIndex = 0;
            this._left.UseCompatibleStateImageBehavior = false;
            this._left.View = System.Windows.Forms.View.Details;
            // 
            // _nameHeaderL
            // 
            this._nameHeaderL.Text = "Имя";
            // 
            // _extensionHeaderL
            // 
            this._extensionHeaderL.Text = "Разрешение";
            // 
            // _sizeHeaderL
            // 
            this._sizeHeaderL.Text = "Размер";
            // 
            // _right
            // 
            this._right.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._nameHeaderR,
            this._extensionHeaderR,
            this._sizeHeaderR});
            this._right.Dock = System.Windows.Forms.DockStyle.Fill;
            this._right.Location = new System.Drawing.Point(0, 0);
            this._right.Name = "_right";
            this._right.Size = new System.Drawing.Size(399, 563);
            this._right.TabIndex = 0;
            this._right.UseCompatibleStateImageBehavior = false;
            this._right.View = System.Windows.Forms.View.Details;
            // 
            // _nameHeaderR
            // 
            this._nameHeaderR.Text = "Имя";
            // 
            // _extensionHeaderR
            // 
            this._extensionHeaderR.Text = "Разрешение";
            // 
            // _sizeHeaderR
            // 
            this._sizeHeaderR.Text = "Размер";
            // 
            // BoringCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 587);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(815, 625);
            this.MinimumSize = new System.Drawing.Size(815, 625);
            this.Name = "BoringCommander";
            this.Text = "BoringCommander";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader _nameHeaderL;
        private System.Windows.Forms.ColumnHeader _extensionHeaderL;
        private System.Windows.Forms.ColumnHeader _sizeHeaderL;
        private System.Windows.Forms.ColumnHeader _nameHeaderR;
        private System.Windows.Forms.ColumnHeader _extensionHeaderR;
        private System.Windows.Forms.ColumnHeader _sizeHeaderR;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        internal System.Windows.Forms.ListView _left;
        internal System.Windows.Forms.ListView _right;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
    }
}


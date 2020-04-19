namespace BulgariaSightseeing
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sofiaLabel = new System.Windows.Forms.Label();
            this.burgasLabel = new System.Windows.Forms.Label();
            this.slivenLabel = new System.Windows.Forms.Label();
            this.vTarnovoLabel = new System.Windows.Forms.Label();
            this.varnaLabel = new System.Windows.Forms.Label();
            this.townsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.forTownMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landmarksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.townsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BulgariaSightseeing.Properties.Resources.BulgariaMap;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sofiaLabel
            // 
            this.sofiaLabel.AutoSize = true;
            this.sofiaLabel.ContextMenuStrip = this.townsMenuStrip;
            this.sofiaLabel.Location = new System.Drawing.Point(76, 214);
            this.sofiaLabel.Name = "sofiaLabel";
            this.sofiaLabel.Size = new System.Drawing.Size(40, 13);
            this.sofiaLabel.TabIndex = 1;
            this.sofiaLabel.Text = "София";
            // 
            // burgasLabel
            // 
            this.burgasLabel.AutoSize = true;
            this.burgasLabel.ContextMenuStrip = this.townsMenuStrip;
            this.burgasLabel.Location = new System.Drawing.Point(438, 231);
            this.burgasLabel.Name = "burgasLabel";
            this.burgasLabel.Size = new System.Drawing.Size(42, 13);
            this.burgasLabel.TabIndex = 2;
            this.burgasLabel.Text = "Бургас";
            // 
            // slivenLabel
            // 
            this.slivenLabel.AutoSize = true;
            this.slivenLabel.ContextMenuStrip = this.townsMenuStrip;
            this.slivenLabel.Location = new System.Drawing.Point(335, 223);
            this.slivenLabel.Name = "slivenLabel";
            this.slivenLabel.Size = new System.Drawing.Size(44, 13);
            this.slivenLabel.TabIndex = 3;
            this.slivenLabel.Text = "Сливен";
            // 
            // vTarnovoLabel
            // 
            this.vTarnovoLabel.AutoSize = true;
            this.vTarnovoLabel.ContextMenuStrip = this.townsMenuStrip;
            this.vTarnovoLabel.Location = new System.Drawing.Point(272, 158);
            this.vTarnovoLabel.Name = "vTarnovoLabel";
            this.vTarnovoLabel.Size = new System.Drawing.Size(94, 13);
            this.vTarnovoLabel.TabIndex = 4;
            this.vTarnovoLabel.Text = "Велико  Търново";
            // 
            // varnaLabel
            // 
            this.varnaLabel.AutoSize = true;
            this.varnaLabel.ContextMenuStrip = this.townsMenuStrip;
            this.varnaLabel.Location = new System.Drawing.Point(473, 150);
            this.varnaLabel.Name = "varnaLabel";
            this.varnaLabel.Size = new System.Drawing.Size(38, 13);
            this.varnaLabel.TabIndex = 5;
            this.varnaLabel.Text = "Варна";
            // 
            // townsMenuStrip
            // 
            this.townsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forTownMenuItem,
            this.historyMenuItem,
            this.landmarksMenuItem});
            this.townsMenuStrip.Name = "townsMenuStrip";
            this.townsMenuStrip.Size = new System.Drawing.Size(180, 70);
            // 
            // forTownMenuItem
            // 
            this.forTownMenuItem.Name = "forTownMenuItem";
            this.forTownMenuItem.Size = new System.Drawing.Size(179, 22);
            this.forTownMenuItem.Text = "За града";
            this.forTownMenuItem.Click += new System.EventHandler(this.forTownMenuItem_Click);
            // 
            // historyMenuItem
            // 
            this.historyMenuItem.Name = "historyMenuItem";
            this.historyMenuItem.Size = new System.Drawing.Size(179, 22);
            this.historyMenuItem.Text = "История";
            this.historyMenuItem.Click += new System.EventHandler(this.historyMenuItem_Click);
            // 
            // landmarksMenuItem
            // 
            this.landmarksMenuItem.Name = "landmarksMenuItem";
            this.landmarksMenuItem.Size = new System.Drawing.Size(179, 22);
            this.landmarksMenuItem.Text = "Забележителности";
            this.landmarksMenuItem.Click += new System.EventHandler(this.landmarksMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 411);
            this.Controls.Add(this.varnaLabel);
            this.Controls.Add(this.vTarnovoLabel);
            this.Controls.Add(this.slivenLabel);
            this.Controls.Add(this.burgasLabel);
            this.Controls.Add(this.sofiaLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.townsMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sofiaLabel;
        private System.Windows.Forms.Label burgasLabel;
        private System.Windows.Forms.Label slivenLabel;
        private System.Windows.Forms.Label vTarnovoLabel;
        private System.Windows.Forms.Label varnaLabel;
        private System.Windows.Forms.ContextMenuStrip townsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem forTownMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landmarksMenuItem;
    }
}


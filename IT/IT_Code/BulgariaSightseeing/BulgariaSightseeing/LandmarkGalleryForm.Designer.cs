namespace BulgariaSightseeing
{
    partial class LandmarkGalleryForm
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
            this.landmarkGalleryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landmarkPictureBox4 = new System.Windows.Forms.PictureBox();
            this.landmarkPictureBox2 = new System.Windows.Forms.PictureBox();
            this.landmarkPictureBox3 = new System.Windows.Forms.PictureBox();
            this.landmarkPictureBox1 = new System.Windows.Forms.PictureBox();
            this.landmarkGalleryContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.landmarkPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landmarkPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landmarkPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landmarkPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // landmarkGalleryContextMenu
            // 
            this.landmarkGalleryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenuItem});
            this.landmarkGalleryContextMenu.Name = "contextMenuStrip1";
            this.landmarkGalleryContextMenu.Size = new System.Drawing.Size(107, 26);
            // 
            // backMenuItem
            // 
            this.backMenuItem.Name = "backMenuItem";
            this.backMenuItem.Size = new System.Drawing.Size(106, 22);
            this.backMenuItem.Text = "Назад";
            this.backMenuItem.Click += new System.EventHandler(this.backMenuItem_Click);
            // 
            // landmarkPictureBox4
            // 
            this.landmarkPictureBox4.ContextMenuStrip = this.landmarkGalleryContextMenu;
            this.landmarkPictureBox4.Location = new System.Drawing.Point(326, 288);
            this.landmarkPictureBox4.Name = "landmarkPictureBox4";
            this.landmarkPictureBox4.Size = new System.Drawing.Size(262, 221);
            this.landmarkPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.landmarkPictureBox4.TabIndex = 3;
            this.landmarkPictureBox4.TabStop = false;
            // 
            // landmarkPictureBox2
            // 
            this.landmarkPictureBox2.ContextMenuStrip = this.landmarkGalleryContextMenu;
            this.landmarkPictureBox2.Location = new System.Drawing.Point(326, 12);
            this.landmarkPictureBox2.Name = "landmarkPictureBox2";
            this.landmarkPictureBox2.Size = new System.Drawing.Size(262, 221);
            this.landmarkPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.landmarkPictureBox2.TabIndex = 2;
            this.landmarkPictureBox2.TabStop = false;
            // 
            // landmarkPictureBox3
            // 
            this.landmarkPictureBox3.ContextMenuStrip = this.landmarkGalleryContextMenu;
            this.landmarkPictureBox3.Location = new System.Drawing.Point(12, 288);
            this.landmarkPictureBox3.Name = "landmarkPictureBox3";
            this.landmarkPictureBox3.Size = new System.Drawing.Size(262, 221);
            this.landmarkPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.landmarkPictureBox3.TabIndex = 1;
            this.landmarkPictureBox3.TabStop = false;
            // 
            // landmarkPictureBox1
            // 
            this.landmarkPictureBox1.ContextMenuStrip = this.landmarkGalleryContextMenu;
            this.landmarkPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.landmarkPictureBox1.Name = "landmarkPictureBox1";
            this.landmarkPictureBox1.Size = new System.Drawing.Size(262, 221);
            this.landmarkPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.landmarkPictureBox1.TabIndex = 0;
            this.landmarkPictureBox1.TabStop = false;
            // 
            // LandmarkGalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 524);
            this.ContextMenuStrip = this.landmarkGalleryContextMenu;
            this.ControlBox = false;
            this.Controls.Add(this.landmarkPictureBox4);
            this.Controls.Add(this.landmarkPictureBox2);
            this.Controls.Add(this.landmarkPictureBox3);
            this.Controls.Add(this.landmarkPictureBox1);
            this.Name = "LandmarkGalleryForm";
            this.Text = "Галерия";
            this.landmarkGalleryContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.landmarkPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landmarkPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landmarkPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landmarkPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox landmarkPictureBox1;
        private System.Windows.Forms.PictureBox landmarkPictureBox3;
        private System.Windows.Forms.PictureBox landmarkPictureBox2;
        private System.Windows.Forms.PictureBox landmarkPictureBox4;
        private System.Windows.Forms.ContextMenuStrip landmarkGalleryContextMenu;
        private System.Windows.Forms.ToolStripMenuItem backMenuItem;
    }
}
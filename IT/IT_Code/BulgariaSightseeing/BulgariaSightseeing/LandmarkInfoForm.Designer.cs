namespace BulgariaSightseeing
{
    partial class LandmarkInfo
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
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.landmarkInfoContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landmarkInfoContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoTextBox
            // 
            this.infoTextBox.ContextMenuStrip = this.landmarkInfoContextMenu;
            this.infoTextBox.Location = new System.Drawing.Point(12, 10);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(231, 428);
            this.infoTextBox.TabIndex = 2;
            this.infoTextBox.Text = "";
            // 
            // landmarkInfoContextMenu
            // 
            this.landmarkInfoContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenuItem});
            this.landmarkInfoContextMenu.Name = "landmarkInfoContextMenu";
            this.landmarkInfoContextMenu.Size = new System.Drawing.Size(107, 26);
            // 
            // backMenuItem
            // 
            this.backMenuItem.Name = "backMenuItem";
            this.backMenuItem.Size = new System.Drawing.Size(106, 22);
            this.backMenuItem.Text = "Назад";
            this.backMenuItem.Click += new System.EventHandler(this.backMenuItem_Click);
            // 
            // LandmarkInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 450);
            this.ContextMenuStrip = this.landmarkInfoContextMenu;
            this.ControlBox = false;
            this.Controls.Add(this.infoTextBox);
            this.Name = "LandmarkInfo";
            this.Text = "Информация";
            this.landmarkInfoContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.ContextMenuStrip landmarkInfoContextMenu;
        private System.Windows.Forms.ToolStripMenuItem backMenuItem;
    }
}
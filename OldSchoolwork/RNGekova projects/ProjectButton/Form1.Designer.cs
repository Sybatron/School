namespace ProjectButton
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
            this.clickB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickB
            // 
            this.clickB.AutoSize = true;
            this.clickB.Location = new System.Drawing.Point(79, 101);
            this.clickB.Name = "clickB";
            this.clickB.Size = new System.Drawing.Size(134, 45);
            this.clickB.TabIndex = 0;
            this.clickB.Text = "Натисни";
            this.clickB.UseVisualStyleBackColor = true;
            this.clickB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clickB_MouseDown);
            this.clickB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clickB_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.clickB);
            this.Name = "Form1";
            this.Text = "Първи проект";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickB;
    }
}


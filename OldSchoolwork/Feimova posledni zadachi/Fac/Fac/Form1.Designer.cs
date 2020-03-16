namespace Fac
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
            this.DoItB = new System.Windows.Forms.Button();
            this.facNumLab = new System.Windows.Forms.Label();
            this.facLab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.ClearB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoItB
            // 
            this.DoItB.Location = new System.Drawing.Point(12, 163);
            this.DoItB.Name = "DoItB";
            this.DoItB.Size = new System.Drawing.Size(75, 23);
            this.DoItB.TabIndex = 0;
            this.DoItB.Text = "Намери";
            this.DoItB.UseVisualStyleBackColor = true;
            this.DoItB.Click += new System.EventHandler(this.DoItB_Click);
            // 
            // facNumLab
            // 
            this.facNumLab.AutoSize = true;
            this.facNumLab.Location = new System.Drawing.Point(12, 124);
            this.facNumLab.Name = "facNumLab";
            this.facNumLab.Size = new System.Drawing.Size(35, 13);
            this.facNumLab.TabIndex = 1;
            this.facNumLab.Text = "label1";
            // 
            // facLab
            // 
            this.facLab.AutoSize = true;
            this.facLab.Location = new System.Drawing.Point(12, 88);
            this.facLab.Name = "facLab";
            this.facLab.Size = new System.Drawing.Size(35, 13);
            this.facLab.TabIndex = 2;
            this.facLab.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "N! (N факториел)";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(12, 45);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(100, 20);
            this.nBox.TabIndex = 4;
            this.nBox.TextChanged += new System.EventHandler(this.nBox_TextChanged);
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(103, 163);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(75, 23);
            this.ClearB.TabIndex = 5;
            this.ClearB.Text = "Изчисти";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.facLab);
            this.Controls.Add(this.facNumLab);
            this.Controls.Add(this.DoItB);
            this.Name = "Form1";
            this.Text = "Факториел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoItB;
        private System.Windows.Forms.Label facNumLab;
        private System.Windows.Forms.Label facLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Button ClearB;
    }
}


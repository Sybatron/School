namespace Fib
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
            this.fibLab = new System.Windows.Forms.Label();
            this.fibNumLab = new System.Windows.Forms.Label();
            this.DoItB = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.nBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fibLab
            // 
            this.fibLab.AutoSize = true;
            this.fibLab.Location = new System.Drawing.Point(13, 86);
            this.fibLab.Name = "fibLab";
            this.fibLab.Size = new System.Drawing.Size(35, 13);
            this.fibLab.TabIndex = 0;
            this.fibLab.Text = "label1";
            // 
            // fibNumLab
            // 
            this.fibNumLab.AutoSize = true;
            this.fibNumLab.Location = new System.Drawing.Point(13, 119);
            this.fibNumLab.Name = "fibNumLab";
            this.fibNumLab.Size = new System.Drawing.Size(35, 13);
            this.fibNumLab.TabIndex = 1;
            this.fibNumLab.Text = "label2";
            // 
            // DoItB
            // 
            this.DoItB.Location = new System.Drawing.Point(13, 189);
            this.DoItB.Name = "DoItB";
            this.DoItB.Size = new System.Drawing.Size(75, 23);
            this.DoItB.TabIndex = 2;
            this.DoItB.Text = "Намери";
            this.DoItB.UseVisualStyleBackColor = true;
            this.DoItB.Click += new System.EventHandler(this.DoItB_Click);
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(95, 189);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(75, 23);
            this.ClearB.TabIndex = 3;
            this.ClearB.Text = "Изчисти";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(13, 46);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(100, 20);
            this.nBox.TabIndex = 4;
            this.nBox.TextChanged += new System.EventHandler(this.nBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кое по ред число искате:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.DoItB);
            this.Controls.Add(this.fibNumLab);
            this.Controls.Add(this.fibLab);
            this.Name = "Form1";
            this.Text = "Числа на Фибоначи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fibLab;
        private System.Windows.Forms.Label fibNumLab;
        private System.Windows.Forms.Button DoItB;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Label label3;
    }
}


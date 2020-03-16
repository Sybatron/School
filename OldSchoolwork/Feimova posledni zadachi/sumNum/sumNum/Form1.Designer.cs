namespace sumNum
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
            this.ClearB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sumNumsLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoItB
            // 
            this.DoItB.Location = new System.Drawing.Point(15, 150);
            this.DoItB.Name = "DoItB";
            this.DoItB.Size = new System.Drawing.Size(75, 23);
            this.DoItB.TabIndex = 0;
            this.DoItB.Text = "Изчисли";
            this.DoItB.UseVisualStyleBackColor = true;
            this.DoItB.Click += new System.EventHandler(this.DoItB_Click);
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(114, 150);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(75, 23);
            this.ClearB.TabIndex = 1;
            this.ClearB.Text = "Изчисти";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Въведете цяло число:";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(12, 38);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(100, 20);
            this.nBox.TabIndex = 3;
            this.nBox.TextChanged += new System.EventHandler(this.nBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сумата на цифрите е:";
            // 
            // sumNumsLab
            // 
            this.sumNumsLab.AutoSize = true;
            this.sumNumsLab.Location = new System.Drawing.Point(12, 103);
            this.sumNumsLab.Name = "sumNumsLab";
            this.sumNumsLab.Size = new System.Drawing.Size(35, 13);
            this.sumNumsLab.TabIndex = 5;
            this.sumNumsLab.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.sumNumsLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.DoItB);
            this.Name = "Form1";
            this.Text = "Сума цифри";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoItB;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sumNumsLab;
    }
}


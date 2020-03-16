namespace WindowsP3_23
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
            this.doItB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.clearB = new System.Windows.Forms.Button();
            this.nFacLab = new System.Windows.Forms.Label();
            this.resultLab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doItB
            // 
            this.doItB.Location = new System.Drawing.Point(12, 132);
            this.doItB.Name = "doItB";
            this.doItB.Size = new System.Drawing.Size(75, 23);
            this.doItB.TabIndex = 0;
            this.doItB.Text = "Пресметни";
            this.doItB.UseVisualStyleBackColor = false;
            this.doItB.Click += new System.EventHandler(this.doItB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N! (N факториел):";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(12, 37);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(35, 20);
            this.nBox.TabIndex = 2;
            this.nBox.TextChanged += new System.EventHandler(this.nBox_TextChanged);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(93, 132);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 3;
            this.clearB.Text = "Изчисти";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // nFacLab
            // 
            this.nFacLab.AutoSize = true;
            this.nFacLab.Location = new System.Drawing.Point(12, 72);
            this.nFacLab.Name = "nFacLab";
            this.nFacLab.Size = new System.Drawing.Size(35, 13);
            this.nFacLab.TabIndex = 4;
            this.nFacLab.Text = "label3";
            // 
            // resultLab
            // 
            this.resultLab.Location = new System.Drawing.Point(12, 100);
            this.resultLab.Name = "resultLab";
            this.resultLab.Size = new System.Drawing.Size(285, 17);
            this.resultLab.TabIndex = 5;
            this.resultLab.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(152, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "N! (N факториел):\r\nN!=1.2.3...N";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 180);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultLab);
            this.Controls.Add(this.nFacLab);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doItB);
            this.Name = "Form1";
            this.Text = "Пресметни N!(N факториел)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doItB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Label nFacLab;
        private System.Windows.Forms.Label resultLab;
        private System.Windows.Forms.Label label4;
    }
}


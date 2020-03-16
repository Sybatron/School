namespace WindowsP3_24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.doItB = new System.Windows.Forms.Button();
            this.resultLab = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nFacLab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // doItB
            // 
            this.doItB.Location = new System.Drawing.Point(12, 133);
            this.doItB.Name = "doItB";
            this.doItB.Size = new System.Drawing.Size(75, 23);
            this.doItB.TabIndex = 0;
            this.doItB.Text = "Пресметни";
            this.doItB.UseVisualStyleBackColor = true;
            this.doItB.Click += new System.EventHandler(this.doItB_Click);
            // 
            // resultLab
            // 
            this.resultLab.AutoSize = true;
            this.resultLab.Location = new System.Drawing.Point(12, 103);
            this.resultLab.Name = "resultLab";
            this.resultLab.Size = new System.Drawing.Size(35, 13);
            this.resultLab.TabIndex = 1;
            this.resultLab.Text = "label1";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(12, 38);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(35, 20);
            this.nBox.TabIndex = 2;
            this.nBox.TextChanged += new System.EventHandler(this.nBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(93, 133);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 4;
            this.clearB.Text = "Изчисти";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Въведете N!!";
            // 
            // nFacLab
            // 
            this.nFacLab.AutoSize = true;
            this.nFacLab.Location = new System.Drawing.Point(12, 74);
            this.nFacLab.Name = "nFacLab";
            this.nFacLab.Size = new System.Drawing.Size(35, 13);
            this.nFacLab.TabIndex = 6;
            this.nFacLab.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "N!! (N двоен факториел)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 253);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nFacLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.resultLab);
            this.Controls.Add(this.doItB);
            this.Name = "Form1";
            this.Text = "Пресметни N!!(N двоен факториел)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doItB;
        private System.Windows.Forms.Label resultLab;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nFacLab;
        private System.Windows.Forms.Label label4;
    }
}


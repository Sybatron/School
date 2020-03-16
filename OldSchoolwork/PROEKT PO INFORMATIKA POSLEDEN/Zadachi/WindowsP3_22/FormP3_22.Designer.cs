namespace WindowsP3_22
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.doItB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // doItB
            // 
            this.doItB.Location = new System.Drawing.Point(12, 115);
            this.doItB.Name = "doItB";
            this.doItB.Size = new System.Drawing.Size(75, 23);
            this.doItB.TabIndex = 0;
            this.doItB.Text = "Пресметни";
            this.doItB.UseVisualStyleBackColor = true;
            this.doItB.Click += new System.EventHandler(this.doItB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(93, 115);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 1;
            this.clearB.Text = "Изчисти";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Въведете N:";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(12, 32);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(35, 20);
            this.nBox.TabIndex = 3;
            this.nBox.TextChanged += new System.EventHandler(this.nBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Резултат:";
            // 
            // resultLab
            // 
            this.resultLab.AutoSize = true;
            this.resultLab.Location = new System.Drawing.Point(12, 84);
            this.resultLab.Name = "resultLab";
            this.resultLab.Size = new System.Drawing.Size(35, 13);
            this.resultLab.TabIndex = 6;
            this.resultLab.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(257, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Хармонична редица:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 167);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.doItB);
            this.Name = "Form";
            this.Text = "Сума от първите N елемента на хармоничната редица";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doItB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLab;
        private System.Windows.Forms.Label label4;
    }
}


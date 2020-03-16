namespace WindowFormP2_12
{
    partial class WindowsFormP2_12
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
            this.clearB = new System.Windows.Forms.Button();
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.TextBox();
            this.aLab = new System.Windows.Forms.Label();
            this.cLab = new System.Windows.Forms.Label();
            this.kor1Lab = new System.Windows.Forms.Label();
            this.bLab = new System.Windows.Forms.Label();
            this.errorLab = new System.Windows.Forms.Label();
            this.normalLookLab = new System.Windows.Forms.Label();
            this.kor3Lab = new System.Windows.Forms.Label();
            this.kor4Lab = new System.Windows.Forms.Label();
            this.kor2Lab = new System.Windows.Forms.Label();
            this.forNowLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doItB
            // 
            this.doItB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.doItB.Location = new System.Drawing.Point(12, 272);
            this.doItB.Name = "doItB";
            this.doItB.Size = new System.Drawing.Size(75, 23);
            this.doItB.TabIndex = 0;
            this.doItB.Text = "Реши...";
            this.doItB.UseVisualStyleBackColor = true;
            this.doItB.Click += new System.EventHandler(this.doItB_Click);
            // 
            // clearB
            // 
            this.clearB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearB.Location = new System.Drawing.Point(93, 272);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 1;
            this.clearB.Text = "Изчисти...";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(12, 70);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(100, 20);
            this.aBox.TabIndex = 2;
            this.aBox.TextChanged += new System.EventHandler(this.aBox_TextChanged);
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(12, 119);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(100, 20);
            this.bBox.TabIndex = 3;
            this.bBox.TextChanged += new System.EventHandler(this.bBox_TextChanged);
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(12, 168);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(100, 20);
            this.cBox.TabIndex = 4;
            this.cBox.TextChanged += new System.EventHandler(this.cBox_TextChanged);
            // 
            // aLab
            // 
            this.aLab.AutoSize = true;
            this.aLab.Location = new System.Drawing.Point(12, 49);
            this.aLab.Name = "aLab";
            this.aLab.Size = new System.Drawing.Size(68, 13);
            this.aLab.TabIndex = 5;
            this.aLab.Text = "Въведете a:";
            // 
            // cLab
            // 
            this.cLab.AutoSize = true;
            this.cLab.Location = new System.Drawing.Point(12, 147);
            this.cLab.Name = "cLab";
            this.cLab.Size = new System.Drawing.Size(68, 13);
            this.cLab.TabIndex = 6;
            this.cLab.Text = "Въведете c:";
            // 
            // kor1Lab
            // 
            this.kor1Lab.AutoSize = true;
            this.kor1Lab.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kor1Lab.ForeColor = System.Drawing.Color.DarkGreen;
            this.kor1Lab.Location = new System.Drawing.Point(233, 47);
            this.kor1Lab.Name = "kor1Lab";
            this.kor1Lab.Size = new System.Drawing.Size(47, 15);
            this.kor1Lab.TabIndex = 7;
            this.kor1Lab.Text = "Корен1";
            // 
            // bLab
            // 
            this.bLab.AutoSize = true;
            this.bLab.Location = new System.Drawing.Point(12, 98);
            this.bLab.Name = "bLab";
            this.bLab.Size = new System.Drawing.Size(68, 13);
            this.bLab.TabIndex = 8;
            this.bLab.Text = "Въведете b:";
            // 
            // errorLab
            // 
            this.errorLab.AutoSize = true;
            this.errorLab.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLab.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.errorLab.Location = new System.Drawing.Point(9, 230);
            this.errorLab.Name = "errorLab";
            this.errorLab.Size = new System.Drawing.Size(49, 14);
            this.errorLab.TabIndex = 9;
            this.errorLab.Text = "label5";
            // 
            // normalLookLab
            // 
            this.normalLookLab.AutoSize = true;
            this.normalLookLab.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalLookLab.ForeColor = System.Drawing.Color.SaddleBrown;
            this.normalLookLab.Location = new System.Drawing.Point(9, 9);
            this.normalLookLab.Name = "normalLookLab";
            this.normalLookLab.Size = new System.Drawing.Size(271, 32);
            this.normalLookLab.TabIndex = 10;
            this.normalLookLab.Text = "Основния вид на биквадратното уравние е:\r\nax^4 + bx^2 + c = 0";
            // 
            // kor3Lab
            // 
            this.kor3Lab.AutoSize = true;
            this.kor3Lab.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kor3Lab.ForeColor = System.Drawing.Color.DarkGreen;
            this.kor3Lab.Location = new System.Drawing.Point(233, 127);
            this.kor3Lab.Name = "kor3Lab";
            this.kor3Lab.Size = new System.Drawing.Size(47, 15);
            this.kor3Lab.TabIndex = 11;
            this.kor3Lab.Text = "Корен3";
            // 
            // kor4Lab
            // 
            this.kor4Lab.AutoSize = true;
            this.kor4Lab.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kor4Lab.ForeColor = System.Drawing.Color.DarkGreen;
            this.kor4Lab.Location = new System.Drawing.Point(233, 167);
            this.kor4Lab.Name = "kor4Lab";
            this.kor4Lab.Size = new System.Drawing.Size(47, 15);
            this.kor4Lab.TabIndex = 12;
            this.kor4Lab.Text = "Корен4";
            // 
            // kor2Lab
            // 
            this.kor2Lab.AutoSize = true;
            this.kor2Lab.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kor2Lab.ForeColor = System.Drawing.Color.DarkGreen;
            this.kor2Lab.Location = new System.Drawing.Point(233, 87);
            this.kor2Lab.Name = "kor2Lab";
            this.kor2Lab.Size = new System.Drawing.Size(47, 15);
            this.kor2Lab.TabIndex = 13;
            this.kor2Lab.Text = "Корен2";
            // 
            // forNowLab
            // 
            this.forNowLab.AutoSize = true;
            this.forNowLab.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forNowLab.ForeColor = System.Drawing.Color.DarkViolet;
            this.forNowLab.Location = new System.Drawing.Point(174, 280);
            this.forNowLab.Name = "forNowLab";
            this.forNowLab.Size = new System.Drawing.Size(42, 15);
            this.forNowLab.TabIndex = 14;
            this.forNowLab.Text = "label1";
            // 
            // WindowsFormP2_12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(356, 312);
            this.Controls.Add(this.forNowLab);
            this.Controls.Add(this.kor2Lab);
            this.Controls.Add(this.kor4Lab);
            this.Controls.Add(this.kor3Lab);
            this.Controls.Add(this.normalLookLab);
            this.Controls.Add(this.errorLab);
            this.Controls.Add(this.bLab);
            this.Controls.Add(this.kor1Lab);
            this.Controls.Add(this.cLab);
            this.Controls.Add(this.aLab);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.doItB);
            this.Name = "WindowsFormP2_12";
            this.Text = "WindowsFormP2_12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doItB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.Label aLab;
        private System.Windows.Forms.Label cLab;
        private System.Windows.Forms.Label kor1Lab;
        private System.Windows.Forms.Label bLab;
        private System.Windows.Forms.Label errorLab;
        private System.Windows.Forms.Label normalLookLab;
        private System.Windows.Forms.Label kor3Lab;
        private System.Windows.Forms.Label kor4Lab;
        private System.Windows.Forms.Label kor2Lab;
        private System.Windows.Forms.Label forNowLab;
    }
}


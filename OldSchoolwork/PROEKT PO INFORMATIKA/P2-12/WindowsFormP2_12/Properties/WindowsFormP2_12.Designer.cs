namespace WindowsFormP2_12
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
            this.aLab = new System.Windows.Forms.Label();
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.bLab = new System.Windows.Forms.Label();
            this.cBox = new System.Windows.Forms.TextBox();
            this.cLab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLab = new System.Windows.Forms.Label();
            this.kor2Lab = new System.Windows.Forms.Label();
            this.kor1Lab = new System.Windows.Forms.Label();
            this.doItB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.kor3Lab = new System.Windows.Forms.Label();
            this.kor4Lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aLab
            // 
            this.aLab.AutoSize = true;
            this.aLab.Location = new System.Drawing.Point(12, 59);
            this.aLab.Name = "aLab";
            this.aLab.Size = new System.Drawing.Size(57, 13);
            this.aLab.TabIndex = 0;
            this.aLab.Text = "Въведи а:";
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(12, 75);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(100, 20);
            this.aBox.TabIndex = 1;
            this.aBox.TextChanged += new System.EventHandler(this.aBox_TextChanged);
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(12, 114);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(100, 20);
            this.bBox.TabIndex = 3;
            this.bBox.TextChanged += new System.EventHandler(this.bBox_TextChanged);
            // 
            // bLab
            // 
            this.bLab.AutoSize = true;
            this.bLab.Location = new System.Drawing.Point(12, 98);
            this.bLab.Name = "bLab";
            this.bLab.Size = new System.Drawing.Size(57, 13);
            this.bLab.TabIndex = 2;
            this.bLab.Text = "Въведи b:";
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(12, 153);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(100, 20);
            this.cBox.TabIndex = 5;
            this.cBox.TextChanged += new System.EventHandler(this.cBox_TextChanged);
            // 
            // cLab
            // 
            this.cLab.AutoSize = true;
            this.cLab.Location = new System.Drawing.Point(12, 137);
            this.cLab.Name = "cLab";
            this.cLab.Size = new System.Drawing.Size(57, 13);
            this.cLab.TabIndex = 4;
            this.cLab.Text = "Въведи c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Основния вид на биквадратното уравние е: \r\nax^4 + bx^2 + c = 0";
            // 
            // errorLab
            // 
            this.errorLab.AutoSize = true;
            this.errorLab.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLab.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.errorLab.Location = new System.Drawing.Point(12, 200);
            this.errorLab.Name = "errorLab";
            this.errorLab.Size = new System.Drawing.Size(56, 18);
            this.errorLab.TabIndex = 7;
            this.errorLab.Text = "label5";
            // 
            // kor2Lab
            // 
            this.kor2Lab.AutoSize = true;
            this.kor2Lab.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kor2Lab.ForeColor = System.Drawing.Color.LimeGreen;
            this.kor2Lab.Location = new System.Drawing.Point(239, 97);
            this.kor2Lab.Name = "kor2Lab";
            this.kor2Lab.Size = new System.Drawing.Size(63, 17);
            this.kor2Lab.TabIndex = 8;
            this.kor2Lab.Text = "Корен 2";
            // 
            // kor1Lab
            // 
            this.kor1Lab.AutoSize = true;
            this.kor1Lab.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kor1Lab.ForeColor = System.Drawing.Color.LimeGreen;
            this.kor1Lab.Location = new System.Drawing.Point(239, 59);
            this.kor1Lab.Name = "kor1Lab";
            this.kor1Lab.Size = new System.Drawing.Size(63, 17);
            this.kor1Lab.TabIndex = 9;
            this.kor1Lab.Text = "Корен 1";
            // 
            // doItB
            // 
            this.doItB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doItB.Location = new System.Drawing.Point(12, 255);
            this.doItB.Name = "doItB";
            this.doItB.Size = new System.Drawing.Size(75, 23);
            this.doItB.TabIndex = 10;
            this.doItB.Text = "Реши...";
            this.doItB.UseVisualStyleBackColor = true;
            this.doItB.Click += new System.EventHandler(this.doItB_Click);
            // 
            // clearB
            // 
            this.clearB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearB.Location = new System.Drawing.Point(97, 255);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 11;
            this.clearB.Text = "Изчисти...";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // kor3Lab
            // 
            this.kor3Lab.AutoSize = true;
            this.kor3Lab.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kor3Lab.ForeColor = System.Drawing.Color.LimeGreen;
            this.kor3Lab.Location = new System.Drawing.Point(239, 135);
            this.kor3Lab.Name = "kor3Lab";
            this.kor3Lab.Size = new System.Drawing.Size(63, 17);
            this.kor3Lab.TabIndex = 13;
            this.kor3Lab.Text = "Корен 3";
            // 
            // kor4Lab
            // 
            this.kor4Lab.AutoSize = true;
            this.kor4Lab.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kor4Lab.ForeColor = System.Drawing.Color.LimeGreen;
            this.kor4Lab.Location = new System.Drawing.Point(239, 173);
            this.kor4Lab.Name = "kor4Lab";
            this.kor4Lab.Size = new System.Drawing.Size(63, 17);
            this.kor4Lab.TabIndex = 12;
            this.kor4Lab.Text = "Корен 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(348, 292);
            this.Controls.Add(this.kor3Lab);
            this.Controls.Add(this.kor4Lab);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.doItB);
            this.Controls.Add(this.kor1Lab);
            this.Controls.Add(this.kor2Lab);
            this.Controls.Add(this.errorLab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.cLab);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.bLab);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.aLab);
            this.Name = "Form1";
            this.Text = "WindowsFormP2_12";
            this.Activated += new System.EventHandler(this.WindowsFormP2_12_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLab;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.Label bLab;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.Label cLab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errorLab;
        private System.Windows.Forms.Label kor2Lab;
        private System.Windows.Forms.Label kor1Lab;
        private System.Windows.Forms.Button doItB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Label kor3Lab;
        private System.Windows.Forms.Label kor4Lab;
    }
}
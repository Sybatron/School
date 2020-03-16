namespace WindowsForm_P2_41
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
            this.x1Box = new System.Windows.Forms.TextBox();
            this.y1Box = new System.Windows.Forms.TextBox();
            this.y2Box = new System.Windows.Forms.TextBox();
            this.y3Box = new System.Windows.Forms.TextBox();
            this.x2Box = new System.Windows.Forms.TextBox();
            this.x3Box = new System.Windows.Forms.TextBox();
            this.errorLab = new System.Windows.Forms.Label();
            this.clearB = new System.Windows.Forms.Button();
            this.findPointB = new System.Windows.Forms.Button();
            this.x1Lab = new System.Windows.Forms.Label();
            this.y1Lab = new System.Windows.Forms.Label();
            this.x2Lab = new System.Windows.Forms.Label();
            this.y3Lab = new System.Windows.Forms.Label();
            this.y2Lab = new System.Windows.Forms.Label();
            this.x3Lab = new System.Windows.Forms.Label();
            this.lowestXLab = new System.Windows.Forms.Label();
            this.lowestYLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x1Box
            // 
            this.x1Box.Location = new System.Drawing.Point(12, 25);
            this.x1Box.Name = "x1Box";
            this.x1Box.Size = new System.Drawing.Size(100, 20);
            this.x1Box.TabIndex = 0;
            this.x1Box.TextChanged += new System.EventHandler(this.x1Box_TextChanged);
            // 
            // y1Box
            // 
            this.y1Box.Location = new System.Drawing.Point(12, 64);
            this.y1Box.Name = "y1Box";
            this.y1Box.Size = new System.Drawing.Size(100, 20);
            this.y1Box.TabIndex = 1;
            this.y1Box.TextChanged += new System.EventHandler(this.y1Box_TextChanged);
            // 
            // y2Box
            // 
            this.y2Box.Location = new System.Drawing.Point(119, 64);
            this.y2Box.Name = "y2Box";
            this.y2Box.Size = new System.Drawing.Size(100, 20);
            this.y2Box.TabIndex = 3;
            this.y2Box.TextChanged += new System.EventHandler(this.y2Box_TextChanged);
            // 
            // y3Box
            // 
            this.y3Box.Location = new System.Drawing.Point(226, 64);
            this.y3Box.Name = "y3Box";
            this.y3Box.Size = new System.Drawing.Size(100, 20);
            this.y3Box.TabIndex = 2;
            this.y3Box.TextChanged += new System.EventHandler(this.y3Box_TextChanged);
            // 
            // x2Box
            // 
            this.x2Box.Location = new System.Drawing.Point(119, 25);
            this.x2Box.Name = "x2Box";
            this.x2Box.Size = new System.Drawing.Size(100, 20);
            this.x2Box.TabIndex = 5;
            this.x2Box.TextChanged += new System.EventHandler(this.x2Box_TextChanged);
            // 
            // x3Box
            // 
            this.x3Box.Location = new System.Drawing.Point(226, 25);
            this.x3Box.Name = "x3Box";
            this.x3Box.Size = new System.Drawing.Size(100, 20);
            this.x3Box.TabIndex = 4;
            this.x3Box.TextChanged += new System.EventHandler(this.x3Box_TextChanged);
            // 
            // errorLab
            // 
            this.errorLab.AutoSize = true;
            this.errorLab.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.errorLab.Location = new System.Drawing.Point(12, 99);
            this.errorLab.Name = "errorLab";
            this.errorLab.Size = new System.Drawing.Size(35, 13);
            this.errorLab.TabIndex = 6;
            this.errorLab.Text = "label1";
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(195, 126);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(131, 23);
            this.clearB.TabIndex = 13;
            this.clearB.Text = "Изчисти...";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // findPointB
            // 
            this.findPointB.Location = new System.Drawing.Point(12, 126);
            this.findPointB.Name = "findPointB";
            this.findPointB.Size = new System.Drawing.Size(177, 23);
            this.findPointB.TabIndex = 14;
            this.findPointB.Text = "Намери най-ниската точка";
            this.findPointB.UseVisualStyleBackColor = true;
            this.findPointB.Click += new System.EventHandler(this.findPointB_Click);
            // 
            // x1Lab
            // 
            this.x1Lab.AutoSize = true;
            this.x1Lab.Location = new System.Drawing.Point(9, 9);
            this.x1Lab.Name = "x1Lab";
            this.x1Lab.Size = new System.Drawing.Size(73, 13);
            this.x1Lab.TabIndex = 7;
            this.x1Lab.Text = "Въведете x1:";
            // 
            // y1Lab
            // 
            this.y1Lab.AutoSize = true;
            this.y1Lab.Location = new System.Drawing.Point(9, 48);
            this.y1Lab.Name = "y1Lab";
            this.y1Lab.Size = new System.Drawing.Size(73, 13);
            this.y1Lab.TabIndex = 8;
            this.y1Lab.Text = "Въведете y1:";
            // 
            // x2Lab
            // 
            this.x2Lab.AutoSize = true;
            this.x2Lab.Location = new System.Drawing.Point(116, 9);
            this.x2Lab.Name = "x2Lab";
            this.x2Lab.Size = new System.Drawing.Size(73, 13);
            this.x2Lab.TabIndex = 9;
            this.x2Lab.Text = "Въведете x2:";
            // 
            // y3Lab
            // 
            this.y3Lab.AutoSize = true;
            this.y3Lab.Location = new System.Drawing.Point(223, 48);
            this.y3Lab.Name = "y3Lab";
            this.y3Lab.Size = new System.Drawing.Size(73, 13);
            this.y3Lab.TabIndex = 10;
            this.y3Lab.Text = "Въведете y3:";
            // 
            // y2Lab
            // 
            this.y2Lab.AutoSize = true;
            this.y2Lab.Location = new System.Drawing.Point(116, 48);
            this.y2Lab.Name = "y2Lab";
            this.y2Lab.Size = new System.Drawing.Size(73, 13);
            this.y2Lab.TabIndex = 11;
            this.y2Lab.Text = "Въведете y2:";
            // 
            // x3Lab
            // 
            this.x3Lab.AutoSize = true;
            this.x3Lab.Location = new System.Drawing.Point(223, 9);
            this.x3Lab.Name = "x3Lab";
            this.x3Lab.Size = new System.Drawing.Size(73, 13);
            this.x3Lab.TabIndex = 12;
            this.x3Lab.Text = "Въведете x3:";
            // 
            // lowestXLab
            // 
            this.lowestXLab.AutoSize = true;
            this.lowestXLab.ForeColor = System.Drawing.Color.DarkGreen;
            this.lowestXLab.Location = new System.Drawing.Point(9, 166);
            this.lowestXLab.Name = "lowestXLab";
            this.lowestXLab.Size = new System.Drawing.Size(193, 13);
            this.lowestXLab.TabIndex = 15;
            this.lowestXLab.Text = "Кординатата X на най-ниската точка";
            // 
            // lowestYLab
            // 
            this.lowestYLab.AutoSize = true;
            this.lowestYLab.ForeColor = System.Drawing.Color.DarkGreen;
            this.lowestYLab.Location = new System.Drawing.Point(9, 191);
            this.lowestYLab.Name = "lowestYLab";
            this.lowestYLab.Size = new System.Drawing.Size(193, 13);
            this.lowestYLab.TabIndex = 16;
            this.lowestYLab.Text = "Кординатата Y на най-ниската точка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(350, 237);
            this.Controls.Add(this.lowestYLab);
            this.Controls.Add(this.lowestXLab);
            this.Controls.Add(this.findPointB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.x3Lab);
            this.Controls.Add(this.y2Lab);
            this.Controls.Add(this.y3Lab);
            this.Controls.Add(this.x2Lab);
            this.Controls.Add(this.y1Lab);
            this.Controls.Add(this.x1Lab);
            this.Controls.Add(this.errorLab);
            this.Controls.Add(this.x2Box);
            this.Controls.Add(this.x3Box);
            this.Controls.Add(this.y2Box);
            this.Controls.Add(this.y3Box);
            this.Controls.Add(this.y1Box);
            this.Controls.Add(this.x1Box);
            this.Name = "Form1";
            this.Text = "Намери най-ниската точка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1Box;
        private System.Windows.Forms.TextBox y1Box;
        private System.Windows.Forms.TextBox y2Box;
        private System.Windows.Forms.TextBox y3Box;
        private System.Windows.Forms.TextBox x2Box;
        private System.Windows.Forms.TextBox x3Box;
        private System.Windows.Forms.Label errorLab;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button findPointB;
        private System.Windows.Forms.Label x1Lab;
        private System.Windows.Forms.Label y1Lab;
        private System.Windows.Forms.Label x2Lab;
        private System.Windows.Forms.Label y3Lab;
        private System.Windows.Forms.Label y2Lab;
        private System.Windows.Forms.Label x3Lab;
        private System.Windows.Forms.Label lowestXLab;
        private System.Windows.Forms.Label lowestYLab;
    }
}


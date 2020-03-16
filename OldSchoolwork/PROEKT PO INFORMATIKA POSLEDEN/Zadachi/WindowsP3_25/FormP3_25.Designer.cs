namespace WindowsP3_25
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
            this.aRB = new System.Windows.Forms.RadioButton();
            this.doItB = new System.Windows.Forms.Button();
            this.mLab = new System.Windows.Forms.Label();
            this.mBox = new System.Windows.Forms.TextBox();
            this.bRB = new System.Windows.Forms.RadioButton();
            this.nLab = new System.Windows.Forms.Label();
            this.clearB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // aRB
            // 
            this.aRB.AutoSize = true;
            this.aRB.Location = new System.Drawing.Point(12, 12);
            this.aRB.Name = "aRB";
            this.aRB.Size = new System.Drawing.Size(69, 17);
            this.aRB.TabIndex = 0;
            this.aRB.TabStop = true;
            this.aRB.Text = "А) 1\"-40\"";
            this.aRB.UseVisualStyleBackColor = true;
            this.aRB.CheckedChanged += new System.EventHandler(this.aRB_CheckedChanged);
            // 
            // doItB
            // 
            this.doItB.Location = new System.Drawing.Point(12, 120);
            this.doItB.Name = "doItB";
            this.doItB.Size = new System.Drawing.Size(75, 23);
            this.doItB.TabIndex = 1;
            this.doItB.Text = "Изведи";
            this.doItB.UseVisualStyleBackColor = true;
            this.doItB.Click += new System.EventHandler(this.doItB_Click);
            // 
            // mLab
            // 
            this.mLab.AutoSize = true;
            this.mLab.Location = new System.Drawing.Point(12, 52);
            this.mLab.Name = "mLab";
            this.mLab.Size = new System.Drawing.Size(21, 13);
            this.mLab.TabIndex = 2;
            this.mLab.Text = "M\"";
            // 
            // mBox
            // 
            this.mBox.Location = new System.Drawing.Point(12, 68);
            this.mBox.Name = "mBox";
            this.mBox.Size = new System.Drawing.Size(38, 20);
            this.mBox.TabIndex = 3;
            // 
            // bRB
            // 
            this.bRB.AutoSize = true;
            this.bRB.Location = new System.Drawing.Point(84, 12);
            this.bRB.Name = "bRB";
            this.bRB.Size = new System.Drawing.Size(68, 17);
            this.bRB.TabIndex = 4;
            this.bRB.TabStop = true;
            this.bRB.Text = "Б) M\"-N\"";
            this.bRB.UseVisualStyleBackColor = true;
            this.bRB.CheckedChanged += new System.EventHandler(this.bRB_CheckedChanged);
            // 
            // nLab
            // 
            this.nLab.AutoSize = true;
            this.nLab.Location = new System.Drawing.Point(53, 52);
            this.nLab.Name = "nLab";
            this.nLab.Size = new System.Drawing.Size(20, 13);
            this.nLab.TabIndex = 5;
            this.nLab.Text = "N\"";
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(93, 120);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 7;
            this.clearB.Text = "Изчистли";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(193, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "1\"=2,54см";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(56, 68);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(38, 20);
            this.nBox.TabIndex = 10;
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView.Location = new System.Drawing.Point(15, 154);
            this.listView.Name = "listView";
            this.listView.ReadOnly = true;
            this.listView.Size = new System.Drawing.Size(153, 96);
            this.listView.TabIndex = 11;
            this.listView.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 262);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.nLab);
            this.Controls.Add(this.bRB);
            this.Controls.Add(this.mBox);
            this.Controls.Add(this.mLab);
            this.Controls.Add(this.doItB);
            this.Controls.Add(this.aRB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton aRB;
        private System.Windows.Forms.Button doItB;
        private System.Windows.Forms.Label mLab;
        private System.Windows.Forms.TextBox mBox;
        private System.Windows.Forms.RadioButton bRB;
        private System.Windows.Forms.Label nLab;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.RichTextBox listView;
    }
}


namespace IT_25_March_2020
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
            this.birthdayButton = new System.Windows.Forms.Button();
            this.birthdayNameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.presentCountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.havePartyCB = new System.Windows.Forms.CheckBox();
            this.partyButton = new System.Windows.Forms.Button();
            this.partyProgressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birthdayButton
            // 
            this.birthdayButton.Location = new System.Drawing.Point(12, 12);
            this.birthdayButton.Name = "birthdayButton";
            this.birthdayButton.Size = new System.Drawing.Size(147, 67);
            this.birthdayButton.TabIndex = 0;
            this.birthdayButton.Text = "Say Happy Birthday";
            this.birthdayButton.UseVisualStyleBackColor = true;
            this.birthdayButton.Click += new System.EventHandler(this.birthdayButton_Click);
            // 
            // birthdayNameButton
            // 
            this.birthdayNameButton.Location = new System.Drawing.Point(12, 85);
            this.birthdayNameButton.Name = "birthdayNameButton";
            this.birthdayNameButton.Size = new System.Drawing.Size(147, 67);
            this.birthdayNameButton.TabIndex = 1;
            this.birthdayNameButton.Text = "Say Happy Birthday Name";
            this.birthdayNameButton.UseVisualStyleBackColor = true;
            this.birthdayNameButton.Click += new System.EventHandler(this.birthdayNameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(165, 123);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(138, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // presentCountTextBox
            // 
            this.presentCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentCountTextBox.Location = new System.Drawing.Point(166, 51);
            this.presentCountTextBox.Name = "presentCountTextBox";
            this.presentCountTextBox.Size = new System.Drawing.Size(138, 22);
            this.presentCountTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count  of presents:";
            // 
            // havePartyCB
            // 
            this.havePartyCB.AutoSize = true;
            this.havePartyCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.havePartyCB.Location = new System.Drawing.Point(168, 173);
            this.havePartyCB.Name = "havePartyCB";
            this.havePartyCB.Size = new System.Drawing.Size(101, 20);
            this.havePartyCB.TabIndex = 6;
            this.havePartyCB.Text = "Have Party?";
            this.havePartyCB.UseVisualStyleBackColor = true;
            // 
            // partyButton
            // 
            this.partyButton.Location = new System.Drawing.Point(12, 158);
            this.partyButton.Name = "partyButton";
            this.partyButton.Size = new System.Drawing.Size(147, 67);
            this.partyButton.TabIndex = 7;
            this.partyButton.Text = "Make Birthday Party";
            this.partyButton.UseVisualStyleBackColor = true;
            this.partyButton.Click += new System.EventHandler(this.partyButton_Click);
            // 
            // partyProgressButton
            // 
            this.partyProgressButton.Location = new System.Drawing.Point(12, 231);
            this.partyProgressButton.Name = "partyProgressButton";
            this.partyProgressButton.Size = new System.Drawing.Size(147, 67);
            this.partyProgressButton.TabIndex = 8;
            this.partyProgressButton.Text = "Show party progress";
            this.partyProgressButton.UseVisualStyleBackColor = true;
            this.partyProgressButton.Click += new System.EventHandler(this.partyProgressButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 414);
            this.Controls.Add(this.partyProgressButton);
            this.Controls.Add(this.partyButton);
            this.Controls.Add(this.havePartyCB);
            this.Controls.Add(this.presentCountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthdayNameButton);
            this.Controls.Add(this.birthdayButton);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button birthdayButton;
        private System.Windows.Forms.Button birthdayNameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox presentCountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox havePartyCB;
        private System.Windows.Forms.Button partyButton;
        private System.Windows.Forms.Button partyProgressButton;
    }
}


namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.classTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fizBox = new System.Windows.Forms.NumericUpDown();
            this.himBox = new System.Windows.Forms.NumericUpDown();
            this.bioBox = new System.Windows.Forms.NumericUpDown();
            this.matBox = new System.Windows.Forms.NumericUpDown();
            this.anglBox = new System.Windows.Forms.NumericUpDown();
            this.belBox = new System.Windows.Forms.NumericUpDown();
            this.numBox = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.readButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.avgTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fizBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.himBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anglBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "№";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(15, 218);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 56);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Запази";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Име";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(123, 15);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(106, 20);
            this.nameTB.TabIndex = 3;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "БЕЛ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Физика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Англ.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Химия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Клас";
            // 
            // classTB
            // 
            this.classTB.Location = new System.Drawing.Point(275, 15);
            this.classTB.Name = "classTB";
            this.classTB.Size = new System.Drawing.Size(36, 20);
            this.classTB.TabIndex = 13;
            this.classTB.TextChanged += new System.EventHandler(this.classTB_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Мат";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Биология";
            // 
            // fizBox
            // 
            this.fizBox.DecimalPlaces = 2;
            this.fizBox.Location = new System.Drawing.Point(245, 56);
            this.fizBox.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.fizBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fizBox.Name = "fizBox";
            this.fizBox.Size = new System.Drawing.Size(65, 20);
            this.fizBox.TabIndex = 19;
            this.fizBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.fizBox.ValueChanged += new System.EventHandler(this.gradeBox_ValueChanged);
            // 
            // himBox
            // 
            this.himBox.DecimalPlaces = 2;
            this.himBox.Location = new System.Drawing.Point(245, 98);
            this.himBox.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.himBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.himBox.Name = "himBox";
            this.himBox.Size = new System.Drawing.Size(65, 20);
            this.himBox.TabIndex = 20;
            this.himBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.himBox.ValueChanged += new System.EventHandler(this.gradeBox_ValueChanged);
            // 
            // bioBox
            // 
            this.bioBox.DecimalPlaces = 2;
            this.bioBox.Location = new System.Drawing.Point(245, 140);
            this.bioBox.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.bioBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.bioBox.Name = "bioBox";
            this.bioBox.Size = new System.Drawing.Size(65, 20);
            this.bioBox.TabIndex = 21;
            this.bioBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.bioBox.ValueChanged += new System.EventHandler(this.gradeBox_ValueChanged);
            // 
            // matBox
            // 
            this.matBox.DecimalPlaces = 2;
            this.matBox.Location = new System.Drawing.Point(55, 142);
            this.matBox.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.matBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matBox.Name = "matBox";
            this.matBox.Size = new System.Drawing.Size(65, 20);
            this.matBox.TabIndex = 24;
            this.matBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.matBox.ValueChanged += new System.EventHandler(this.gradeBox_ValueChanged);
            // 
            // anglBox
            // 
            this.anglBox.DecimalPlaces = 2;
            this.anglBox.Location = new System.Drawing.Point(55, 100);
            this.anglBox.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.anglBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.anglBox.Name = "anglBox";
            this.anglBox.Size = new System.Drawing.Size(65, 20);
            this.anglBox.TabIndex = 23;
            this.anglBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.anglBox.ValueChanged += new System.EventHandler(this.gradeBox_ValueChanged);
            // 
            // belBox
            // 
            this.belBox.DecimalPlaces = 2;
            this.belBox.Location = new System.Drawing.Point(55, 58);
            this.belBox.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.belBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.belBox.Name = "belBox";
            this.belBox.Size = new System.Drawing.Size(65, 20);
            this.belBox.TabIndex = 22;
            this.belBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.belBox.ValueChanged += new System.EventHandler(this.gradeBox_ValueChanged);
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(36, 19);
            this.numBox.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.numBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(31, 20);
            this.numBox.TabIndex = 25;
            this.numBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(184, 218);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(114, 56);
            this.readButton.TabIndex = 26;
            this.readButton.Text = "Прочети";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(327, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 231);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // avgTB
            // 
            this.avgTB.Location = new System.Drawing.Point(113, 188);
            this.avgTB.Name = "avgTB";
            this.avgTB.ReadOnly = true;
            this.avgTB.Size = new System.Drawing.Size(65, 20);
            this.avgTB.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Среден успех";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 286);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.avgTB);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.matBox);
            this.Controls.Add(this.anglBox);
            this.Controls.Add(this.belBox);
            this.Controls.Add(this.bioBox);
            this.Controls.Add(this.himBox);
            this.Controls.Add(this.fizBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.classTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "rich";
            ((System.ComponentModel.ISupportInitialize)(this.fizBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.himBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anglBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox classTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown fizBox;
        private System.Windows.Forms.NumericUpDown himBox;
        private System.Windows.Forms.NumericUpDown bioBox;
        private System.Windows.Forms.NumericUpDown matBox;
        private System.Windows.Forms.NumericUpDown anglBox;
        private System.Windows.Forms.NumericUpDown belBox;
        private System.Windows.Forms.NumericUpDown numBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox avgTB;
        private System.Windows.Forms.Label label10;
    }
}


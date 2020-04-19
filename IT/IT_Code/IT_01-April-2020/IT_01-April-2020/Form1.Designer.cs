namespace IT_01_April_2020
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.readWholeFileButton = new System.Windows.Forms.Button();
            this.readFileLBLButton = new System.Windows.Forms.Button();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.writeFileButton = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.chooseNewLocationButton = new System.Windows.Forms.Button();
            this.copyFileButton = new System.Windows.Forms.Button();
            this.moveFileButton = new System.Windows.Forms.Button();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 144);
            this.textBox1.TabIndex = 0;
            // 
            // readWholeFileButton
            // 
            this.readWholeFileButton.Location = new System.Drawing.Point(209, 14);
            this.readWholeFileButton.Name = "readWholeFileButton";
            this.readWholeFileButton.Size = new System.Drawing.Size(124, 23);
            this.readWholeFileButton.TabIndex = 1;
            this.readWholeFileButton.Text = "Read whole file";
            this.readWholeFileButton.UseVisualStyleBackColor = true;
            this.readWholeFileButton.Click += new System.EventHandler(this.ReadWholeFileButton_Click);
            // 
            // readFileLBLButton
            // 
            this.readFileLBLButton.Location = new System.Drawing.Point(209, 43);
            this.readFileLBLButton.Name = "readFileLBLButton";
            this.readFileLBLButton.Size = new System.Drawing.Size(124, 23);
            this.readFileLBLButton.TabIndex = 2;
            this.readFileLBLButton.Text = "Read file line by line";
            this.readFileLBLButton.UseVisualStyleBackColor = true;
            this.readFileLBLButton.Click += new System.EventHandler(this.ReadFileLBLButton_Click);
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(209, 72);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(124, 23);
            this.chooseFileButton.TabIndex = 3;
            this.chooseFileButton.Text = "Choose file";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 185);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 144);
            this.textBox2.TabIndex = 4;
            // 
            // writeFileButton
            // 
            this.writeFileButton.Location = new System.Drawing.Point(207, 185);
            this.writeFileButton.Name = "writeFileButton";
            this.writeFileButton.Size = new System.Drawing.Size(124, 23);
            this.writeFileButton.TabIndex = 5;
            this.writeFileButton.Text = "Write to file";
            this.writeFileButton.UseVisualStyleBackColor = true;
            this.writeFileButton.Click += new System.EventHandler(this.writeFileButton_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            this.openFD.Filter = "Text files|*.txt";
            this.openFD.Title = "Choose text file";
            // 
            // chooseNewLocationButton
            // 
            this.chooseNewLocationButton.Location = new System.Drawing.Point(209, 101);
            this.chooseNewLocationButton.Name = "chooseNewLocationButton";
            this.chooseNewLocationButton.Size = new System.Drawing.Size(124, 23);
            this.chooseNewLocationButton.TabIndex = 6;
            this.chooseNewLocationButton.Text = "Choose new location";
            this.chooseNewLocationButton.UseVisualStyleBackColor = true;
            this.chooseNewLocationButton.Click += new System.EventHandler(this.chooseNewLocationButton_Click);
            // 
            // copyFileButton
            // 
            this.copyFileButton.Location = new System.Drawing.Point(207, 214);
            this.copyFileButton.Name = "copyFileButton";
            this.copyFileButton.Size = new System.Drawing.Size(124, 23);
            this.copyFileButton.TabIndex = 7;
            this.copyFileButton.Text = "Copy file";
            this.copyFileButton.UseVisualStyleBackColor = true;
            this.copyFileButton.Click += new System.EventHandler(this.copyFileButton_Click);
            // 
            // moveFileButton
            // 
            this.moveFileButton.Location = new System.Drawing.Point(207, 243);
            this.moveFileButton.Name = "moveFileButton";
            this.moveFileButton.Size = new System.Drawing.Size(124, 23);
            this.moveFileButton.TabIndex = 8;
            this.moveFileButton.Text = "Move file";
            this.moveFileButton.UseVisualStyleBackColor = true;
            this.moveFileButton.Click += new System.EventHandler(this.moveFileButton_Click);
            // 
            // deleteFileButton
            // 
            this.deleteFileButton.Location = new System.Drawing.Point(207, 272);
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.Size = new System.Drawing.Size(124, 23);
            this.deleteFileButton.TabIndex = 9;
            this.deleteFileButton.Text = "Delete file";
            this.deleteFileButton.UseVisualStyleBackColor = true;
            this.deleteFileButton.Click += new System.EventHandler(this.deleteFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Appended text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteFileButton);
            this.Controls.Add(this.moveFileButton);
            this.Controls.Add(this.copyFileButton);
            this.Controls.Add(this.chooseNewLocationButton);
            this.Controls.Add(this.writeFileButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.readFileLBLButton);
            this.Controls.Add(this.readWholeFileButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button readWholeFileButton;
        private System.Windows.Forms.Button readFileLBLButton;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button writeFileButton;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button chooseNewLocationButton;
        private System.Windows.Forms.Button copyFileButton;
        private System.Windows.Forms.Button moveFileButton;
        private System.Windows.Forms.Button deleteFileButton;
        private System.Windows.Forms.Label label1;
    }
}


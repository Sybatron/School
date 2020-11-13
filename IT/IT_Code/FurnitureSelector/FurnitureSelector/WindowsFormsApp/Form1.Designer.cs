namespace WindowsFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridLayout = new System.Windows.Forms.TableLayoutPanel();
            this.viewButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.objectOptionBox = new System.Windows.Forms.ComboBox();
            this.objectRB1 = new System.Windows.Forms.RadioButton();
            this.objectRB2 = new System.Windows.Forms.RadioButton();
            this.objectRB3 = new System.Windows.Forms.RadioButton();
            this.objectRB4 = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.scrollBar = new System.Windows.Forms.VScrollBar();
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.loadItemsTimer = new System.Windows.Forms.Timer(this.components);
            this.loadShopListTimer = new System.Windows.Forms.Timer(this.components);
            this.gridLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLayout
            // 
            this.gridLayout.ColumnCount = 4;
            this.gridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.gridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.gridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.gridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.gridLayout.Controls.Add(this.viewButton, 1, 0);
            this.gridLayout.Controls.Add(this.panel1, 0, 2);
            this.gridLayout.Controls.Add(this.progressBar, 2, 0);
            this.gridLayout.Controls.Add(this.objectOptionBox, 0, 0);
            this.gridLayout.Controls.Add(this.objectRB1, 0, 1);
            this.gridLayout.Controls.Add(this.objectRB2, 1, 1);
            this.gridLayout.Controls.Add(this.objectRB3, 2, 1);
            this.gridLayout.Controls.Add(this.objectRB4, 3, 1);
            this.gridLayout.Controls.Add(this.addButton, 3, 0);
            this.gridLayout.Controls.Add(this.exitButton, 3, 2);
            this.gridLayout.Location = new System.Drawing.Point(12, 12);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.RowCount = 3;
            this.gridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.gridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.gridLayout.Size = new System.Drawing.Size(490, 200);
            this.gridLayout.TabIndex = 0;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(123, 3);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(114, 23);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "Разгледай";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // panel1
            // 
            this.gridLayout.SetColumnSpan(this.panel1, 3);
            this.panel1.Location = new System.Drawing.Point(3, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 39);
            this.panel1.TabIndex = 4;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(243, 3);
            this.progressBar.MarqueeAnimationSpeed = 125;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(114, 23);
            this.progressBar.TabIndex = 2;
            // 
            // objectOptionBox
            // 
            this.objectOptionBox.FormattingEnabled = true;
            this.objectOptionBox.Items.AddRange(new object[] {
            "столове",
            "маси",
            "гардероби",
            "легла"});
            this.objectOptionBox.Location = new System.Drawing.Point(3, 3);
            this.objectOptionBox.Name = "objectOptionBox";
            this.objectOptionBox.Size = new System.Drawing.Size(114, 21);
            this.objectOptionBox.TabIndex = 0;
            // 
            // objectRB1
            // 
            this.objectRB1.Appearance = System.Windows.Forms.Appearance.Button;
            this.objectRB1.AutoSize = true;
            this.objectRB1.Image = ((System.Drawing.Image)(resources.GetObject("objectRB1.Image")));
            this.objectRB1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.objectRB1.Location = new System.Drawing.Point(3, 32);
            this.objectRB1.Name = "objectRB1";
            this.objectRB1.Size = new System.Drawing.Size(114, 114);
            this.objectRB1.TabIndex = 1;
            this.objectRB1.TabStop = true;
            this.objectRB1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.objectRB1.UseVisualStyleBackColor = true;
            // 
            // objectRB2
            // 
            this.objectRB2.Appearance = System.Windows.Forms.Appearance.Button;
            this.objectRB2.AutoSize = true;
            this.objectRB2.Image = ((System.Drawing.Image)(resources.GetObject("objectRB2.Image")));
            this.objectRB2.Location = new System.Drawing.Point(123, 32);
            this.objectRB2.Name = "objectRB2";
            this.objectRB2.Size = new System.Drawing.Size(114, 114);
            this.objectRB2.TabIndex = 5;
            this.objectRB2.TabStop = true;
            this.objectRB2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.objectRB2.UseVisualStyleBackColor = true;
            // 
            // objectRB3
            // 
            this.objectRB3.Appearance = System.Windows.Forms.Appearance.Button;
            this.objectRB3.AutoSize = true;
            this.objectRB3.Image = ((System.Drawing.Image)(resources.GetObject("objectRB3.Image")));
            this.objectRB3.Location = new System.Drawing.Point(243, 32);
            this.objectRB3.Name = "objectRB3";
            this.objectRB3.Size = new System.Drawing.Size(114, 114);
            this.objectRB3.TabIndex = 6;
            this.objectRB3.TabStop = true;
            this.objectRB3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.objectRB3.UseVisualStyleBackColor = true;
            // 
            // objectRB4
            // 
            this.objectRB4.Appearance = System.Windows.Forms.Appearance.Button;
            this.objectRB4.AutoSize = true;
            this.objectRB4.Image = ((System.Drawing.Image)(resources.GetObject("objectRB4.Image")));
            this.objectRB4.Location = new System.Drawing.Point(363, 32);
            this.objectRB4.Name = "objectRB4";
            this.objectRB4.Size = new System.Drawing.Size(118, 114);
            this.objectRB4.TabIndex = 7;
            this.objectRB4.TabStop = true;
            this.objectRB4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.objectRB4.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(363, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(118, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добави";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(363, 152);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 39);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Изход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scrollBar
            // 
            this.scrollBar.LargeChange = 1;
            this.scrollBar.Location = new System.Drawing.Point(348, 168);
            this.scrollBar.Maximum = 0;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(17, 80);
            this.scrollBar.TabIndex = 0;
            this.scrollBar.ValueChanged += new System.EventHandler(this.scrollBar_ValueChanged);
            // 
            // formTimer
            // 
            this.formTimer.Interval = 250;
            this.formTimer.Tick += new System.EventHandler(this.formTimer_Tick);
            // 
            // loadItemsTimer
            // 
            this.loadItemsTimer.Interval = 250;
            this.loadItemsTimer.Tick += new System.EventHandler(this.loadItemsTimer_Tick);
            // 
            // loadShopListTimer
            // 
            this.loadShopListTimer.Interval = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 205);
            this.ControlBox = false;
            this.Controls.Add(this.scrollBar);
            this.Controls.Add(this.gridLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Магазин за мебели";
            this.gridLayout.ResumeLayout(false);
            this.gridLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gridLayout;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox objectOptionBox;
        private System.Windows.Forms.RadioButton objectRB1;
        private System.Windows.Forms.RadioButton objectRB2;
        private System.Windows.Forms.RadioButton objectRB3;
        private System.Windows.Forms.RadioButton objectRB4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Timer formTimer;
        private System.Windows.Forms.Timer loadItemsTimer;
        private System.Windows.Forms.Timer loadShopListTimer;
        private System.Windows.Forms.VScrollBar scrollBar;
    }
}


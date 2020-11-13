
namespace CarRent
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.calendarElement = new System.Windows.Forms.MonthCalendar();
            this.paymentMethodGB = new System.Windows.Forms.GroupBox();
            this.creditCardRB = new System.Windows.Forms.RadioButton();
            this.childChairCB = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.carSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.asstetsGB = new System.Windows.Forms.GroupBox();
            this.bankRB = new System.Windows.Forms.RadioButton();
            this.cashRB = new System.Windows.Forms.RadioButton();
            this.chainsCB = new System.Windows.Forms.CheckBox();
            this.skiTrunkCB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dailyPriceLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.paymentMethodGB.SuspendLayout();
            this.asstetsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(86, 40);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(100, 20);
            this.firstNameTB.TabIndex = 1;
            // 
            // calendarElement
            // 
            this.calendarElement.Location = new System.Drawing.Point(198, 43);
            this.calendarElement.MaxSelectionCount = 30;
            this.calendarElement.Name = "calendarElement";
            this.calendarElement.TabIndex = 2;
            // 
            // paymentMethodGB
            // 
            this.paymentMethodGB.Controls.Add(this.cashRB);
            this.paymentMethodGB.Controls.Add(this.bankRB);
            this.paymentMethodGB.Controls.Add(this.creditCardRB);
            this.paymentMethodGB.Location = new System.Drawing.Point(198, 271);
            this.paymentMethodGB.Name = "paymentMethodGB";
            this.paymentMethodGB.Size = new System.Drawing.Size(178, 100);
            this.paymentMethodGB.TabIndex = 3;
            this.paymentMethodGB.TabStop = false;
            this.paymentMethodGB.Text = "Начин на плащане";
            // 
            // creditCardRB
            // 
            this.creditCardRB.AutoSize = true;
            this.creditCardRB.Location = new System.Drawing.Point(16, 19);
            this.creditCardRB.Name = "creditCardRB";
            this.creditCardRB.Size = new System.Drawing.Size(114, 17);
            this.creditCardRB.TabIndex = 4;
            this.creditCardRB.TabStop = true;
            this.creditCardRB.Text = "С кредитна карта";
            this.creditCardRB.UseVisualStyleBackColor = true;
            // 
            // childChairCB
            // 
            this.childChairCB.AutoSize = true;
            this.childChairCB.Location = new System.Drawing.Point(21, 19);
            this.childChairCB.Name = "childChairCB";
            this.childChairCB.Size = new System.Drawing.Size(101, 17);
            this.childChairCB.TabIndex = 5;
            this.childChairCB.Tag = "40";
            this.childChairCB.Text = "Детско столче";
            this.childChairCB.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 404);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(413, 34);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Изчисли";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // carSelectorComboBox
            // 
            this.carSelectorComboBox.FormattingEnabled = true;
            this.carSelectorComboBox.Items.AddRange(new object[] {
            "Audi A4",
            "Mazda6",
            "Renault Clio",
            "Toyota Avensis",
            "Toyota Land Cruiser",
            "VW Multivan"});
            this.carSelectorComboBox.Location = new System.Drawing.Point(12, 217);
            this.carSelectorComboBox.Name = "carSelectorComboBox";
            this.carSelectorComboBox.Size = new System.Drawing.Size(121, 21);
            this.carSelectorComboBox.TabIndex = 7;
            this.carSelectorComboBox.Text = "Избери кола ...";
            this.carSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.carSelectorComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Резервация на автомобил";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(86, 73);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(100, 20);
            this.lastNameTB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Фамилия:";
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(86, 107);
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(100, 20);
            this.adressTB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Адрес:";
            // 
            // asstetsGB
            // 
            this.asstetsGB.Controls.Add(this.skiTrunkCB);
            this.asstetsGB.Controls.Add(this.chainsCB);
            this.asstetsGB.Controls.Add(this.childChairCB);
            this.asstetsGB.Location = new System.Drawing.Point(12, 271);
            this.asstetsGB.Name = "asstetsGB";
            this.asstetsGB.Size = new System.Drawing.Size(174, 100);
            this.asstetsGB.TabIndex = 4;
            this.asstetsGB.TabStop = false;
            this.asstetsGB.Text = "Допълнително оборудване";
            // 
            // bankRB
            // 
            this.bankRB.AutoSize = true;
            this.bankRB.Location = new System.Drawing.Point(16, 42);
            this.bankRB.Name = "bankRB";
            this.bankRB.Size = new System.Drawing.Size(99, 17);
            this.bankRB.TabIndex = 5;
            this.bankRB.TabStop = true;
            this.bankRB.Text = "По банков път";
            this.bankRB.UseVisualStyleBackColor = true;
            // 
            // cashRB
            // 
            this.cashRB.AutoSize = true;
            this.cashRB.Location = new System.Drawing.Point(16, 65);
            this.cashRB.Name = "cashRB";
            this.cashRB.Size = new System.Drawing.Size(59, 17);
            this.cashRB.TabIndex = 6;
            this.cashRB.TabStop = true;
            this.cashRB.Text = "В брой";
            this.cashRB.UseVisualStyleBackColor = true;
            // 
            // chainsCB
            // 
            this.chainsCB.AutoSize = true;
            this.chainsCB.Location = new System.Drawing.Point(21, 44);
            this.chainsCB.Name = "chainsCB";
            this.chainsCB.Size = new System.Drawing.Size(103, 17);
            this.chainsCB.TabIndex = 6;
            this.chainsCB.Tag = "45";
            this.chainsCB.Text = "Вериги за сняг";
            this.chainsCB.UseVisualStyleBackColor = true;
            // 
            // skiTrunkCB
            // 
            this.skiTrunkCB.AutoSize = true;
            this.skiTrunkCB.Location = new System.Drawing.Point(21, 69);
            this.skiTrunkCB.Name = "skiTrunkCB";
            this.skiTrunkCB.Size = new System.Drawing.Size(112, 17);
            this.skiTrunkCB.TabIndex = 7;
            this.skiTrunkCB.Tag = "30";
            this.skiTrunkCB.Text = "Багажник за ски";
            this.skiTrunkCB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Данни на клеинта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Избери период за наемане";
            // 
            // dailyPriceLabel
            // 
            this.dailyPriceLabel.AutoSize = true;
            this.dailyPriceLabel.Location = new System.Drawing.Point(373, 225);
            this.dailyPriceLabel.Name = "dailyPriceLabel";
            this.dailyPriceLabel.Size = new System.Drawing.Size(78, 13);
            this.dailyPriceLabel.TabIndex = 15;
            this.dailyPriceLabel.Text = "dailyPriceLabel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Цена на ден за избрания автомобил";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(318, 388);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(58, 13);
            this.resultLabel.TabIndex = 17;
            this.resultLabel.Text = "resultLabel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Сума на избрания автомобил за периода";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Телефон:";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(86, 139);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(100, 20);
            this.phoneTB.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dailyPriceLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.asstetsGB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carSelectorComboBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.paymentMethodGB);
            this.Controls.Add(this.calendarElement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Name = "Form1";
            this.Text = "Автомобил под наем";
            this.paymentMethodGB.ResumeLayout(false);
            this.paymentMethodGB.PerformLayout();
            this.asstetsGB.ResumeLayout(false);
            this.asstetsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.MonthCalendar calendarElement;
        private System.Windows.Forms.GroupBox paymentMethodGB;
        private System.Windows.Forms.RadioButton creditCardRB;
        private System.Windows.Forms.CheckBox childChairCB;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox carSelectorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton cashRB;
        private System.Windows.Forms.RadioButton bankRB;
        private System.Windows.Forms.GroupBox asstetsGB;
        private System.Windows.Forms.CheckBox skiTrunkCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dailyPriceLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.CheckBox chainsCB;
    }
}


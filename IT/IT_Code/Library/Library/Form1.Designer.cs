
namespace Library
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
            this.storageNumberTB = new System.Windows.Forms.TextBox();
            this.pagesCountBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addBookPanel = new System.Windows.Forms.Panel();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewGroupBox = new System.Windows.Forms.GroupBox();
            this.showAllBooksPanel = new System.Windows.Forms.Panel();
            this.booksViewTB = new System.Windows.Forms.RichTextBox();
            this.showAllBooksButton = new System.Windows.Forms.Button();
            this.addBookRB = new System.Windows.Forms.RadioButton();
            this.showAllBooksRB = new System.Windows.Forms.RadioButton();
            this.deleteBookRB = new System.Windows.Forms.RadioButton();
            this.deleteBookBySNPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.searchStorageNumberTB = new System.Windows.Forms.TextBox();
            this.deleteBookBySNButton = new System.Windows.Forms.Button();
            this.calculateBooksSumPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.sumBooksTB = new System.Windows.Forms.TextBox();
            this.calculateBooksSumButton = new System.Windows.Forms.Button();
            this.findBookByAuthorPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.searchAuthorTB = new System.Windows.Forms.TextBox();
            this.authorBooksViewTB = new System.Windows.Forms.RichTextBox();
            this.searchBookByAuthorButton = new System.Windows.Forms.Button();
            this.otherFunctionsPanel = new System.Windows.Forms.Panel();
            this.booksTo15PriceButton = new System.Windows.Forms.Button();
            this.booksТо150PagesButton = new System.Windows.Forms.Button();
            this.showSumRB = new System.Windows.Forms.RadioButton();
            this.findBooksByAuthorRB = new System.Windows.Forms.RadioButton();
            this.otherFunctionsRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pagesCountBox)).BeginInit();
            this.addBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            this.showAllBooksPanel.SuspendLayout();
            this.deleteBookBySNPanel.SuspendLayout();
            this.calculateBooksSumPanel.SuspendLayout();
            this.findBookByAuthorPanel.SuspendLayout();
            this.otherFunctionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // storageNumberTB
            // 
            this.storageNumberTB.Location = new System.Drawing.Point(112, 0);
            this.storageNumberTB.MaxLength = 6;
            this.storageNumberTB.Name = "storageNumberTB";
            this.storageNumberTB.Size = new System.Drawing.Size(100, 20);
            this.storageNumberTB.TabIndex = 0;
            // 
            // pagesCountBox
            // 
            this.pagesCountBox.Location = new System.Drawing.Point(112, 99);
            this.pagesCountBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.pagesCountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pagesCountBox.Name = "pagesCountBox";
            this.pagesCountBox.Size = new System.Drawing.Size(100, 20);
            this.pagesCountBox.TabIndex = 1;
            this.pagesCountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Инвертарен номер";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(0, 170);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(212, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добави книга";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addBookPanel
            // 
            this.addBookPanel.Controls.Add(this.priceBox);
            this.addBookPanel.Controls.Add(this.label5);
            this.addBookPanel.Controls.Add(this.label4);
            this.addBookPanel.Controls.Add(this.titleTB);
            this.addBookPanel.Controls.Add(this.label3);
            this.addBookPanel.Controls.Add(this.authorTB);
            this.addBookPanel.Controls.Add(this.label2);
            this.addBookPanel.Controls.Add(this.storageNumberTB);
            this.addBookPanel.Controls.Add(this.addButton);
            this.addBookPanel.Controls.Add(this.pagesCountBox);
            this.addBookPanel.Controls.Add(this.label1);
            this.addBookPanel.Location = new System.Drawing.Point(586, 12);
            this.addBookPanel.Name = "addBookPanel";
            this.addBookPanel.Size = new System.Drawing.Size(215, 205);
            this.addBookPanel.TabIndex = 4;
            // 
            // priceBox
            // 
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Location = new System.Drawing.Point(112, 134);
            this.priceBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.priceBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 10;
            this.priceBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Брой страници";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена";
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(112, 63);
            this.titleTB.MaxLength = 30;
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(100, 20);
            this.titleTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Заглавие";
            // 
            // authorTB
            // 
            this.authorTB.Location = new System.Drawing.Point(112, 30);
            this.authorTB.MaxLength = 20;
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(100, 20);
            this.authorTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Автор";
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.Location = new System.Drawing.Point(12, 12);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Size = new System.Drawing.Size(291, 393);
            this.viewGroupBox.TabIndex = 5;
            this.viewGroupBox.TabStop = false;
            // 
            // showAllBooksPanel
            // 
            this.showAllBooksPanel.Controls.Add(this.booksViewTB);
            this.showAllBooksPanel.Controls.Add(this.showAllBooksButton);
            this.showAllBooksPanel.Location = new System.Drawing.Point(586, 233);
            this.showAllBooksPanel.Name = "showAllBooksPanel";
            this.showAllBooksPanel.Size = new System.Drawing.Size(215, 205);
            this.showAllBooksPanel.TabIndex = 11;
            // 
            // booksViewTB
            // 
            this.booksViewTB.Location = new System.Drawing.Point(4, 33);
            this.booksViewTB.Name = "booksViewTB";
            this.booksViewTB.ReadOnly = true;
            this.booksViewTB.Size = new System.Drawing.Size(208, 169);
            this.booksViewTB.TabIndex = 4;
            this.booksViewTB.Text = "";
            // 
            // showAllBooksButton
            // 
            this.showAllBooksButton.Location = new System.Drawing.Point(4, 3);
            this.showAllBooksButton.Name = "showAllBooksButton";
            this.showAllBooksButton.Size = new System.Drawing.Size(208, 23);
            this.showAllBooksButton.TabIndex = 3;
            this.showAllBooksButton.Text = "Покажи всички книги";
            this.showAllBooksButton.UseVisualStyleBackColor = true;
            this.showAllBooksButton.Click += new System.EventHandler(this.showAllBooksButton_Click);
            // 
            // addBookRB
            // 
            this.addBookRB.AutoSize = true;
            this.addBookRB.Location = new System.Drawing.Point(309, 19);
            this.addBookRB.Name = "addBookRB";
            this.addBookRB.Size = new System.Drawing.Size(96, 17);
            this.addBookRB.TabIndex = 12;
            this.addBookRB.TabStop = true;
            this.addBookRB.Text = "Добави книга";
            this.addBookRB.UseVisualStyleBackColor = true;
            this.addBookRB.CheckedChanged += new System.EventHandler(this.addBookRB_CheckedChanged);
            // 
            // showAllBooksRB
            // 
            this.showAllBooksRB.AutoSize = true;
            this.showAllBooksRB.Location = new System.Drawing.Point(309, 47);
            this.showAllBooksRB.Name = "showAllBooksRB";
            this.showAllBooksRB.Size = new System.Drawing.Size(116, 17);
            this.showAllBooksRB.TabIndex = 13;
            this.showAllBooksRB.TabStop = true;
            this.showAllBooksRB.Text = "Виж всички книги";
            this.showAllBooksRB.UseVisualStyleBackColor = true;
            this.showAllBooksRB.CheckedChanged += new System.EventHandler(this.showAllBooksRB_CheckedChanged);
            // 
            // deleteBookRB
            // 
            this.deleteBookRB.AutoSize = true;
            this.deleteBookRB.Location = new System.Drawing.Point(309, 75);
            this.deleteBookRB.Name = "deleteBookRB";
            this.deleteBookRB.Size = new System.Drawing.Size(108, 17);
            this.deleteBookRB.TabIndex = 14;
            this.deleteBookRB.TabStop = true;
            this.deleteBookRB.Text = "Премахни книга";
            this.deleteBookRB.UseVisualStyleBackColor = true;
            this.deleteBookRB.CheckedChanged += new System.EventHandler(this.deleteBookRB_CheckedChanged);
            // 
            // deleteBookBySNPanel
            // 
            this.deleteBookBySNPanel.Controls.Add(this.label6);
            this.deleteBookBySNPanel.Controls.Add(this.searchStorageNumberTB);
            this.deleteBookBySNPanel.Controls.Add(this.deleteBookBySNButton);
            this.deleteBookBySNPanel.Location = new System.Drawing.Point(807, 15);
            this.deleteBookBySNPanel.Name = "deleteBookBySNPanel";
            this.deleteBookBySNPanel.Size = new System.Drawing.Size(215, 59);
            this.deleteBookBySNPanel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Инвентарен номер";
            // 
            // searchStorageNumberTB
            // 
            this.searchStorageNumberTB.Location = new System.Drawing.Point(112, 3);
            this.searchStorageNumberTB.MaxLength = 6;
            this.searchStorageNumberTB.Name = "searchStorageNumberTB";
            this.searchStorageNumberTB.Size = new System.Drawing.Size(100, 20);
            this.searchStorageNumberTB.TabIndex = 11;
            // 
            // deleteBookBySNButton
            // 
            this.deleteBookBySNButton.Location = new System.Drawing.Point(6, 29);
            this.deleteBookBySNButton.Name = "deleteBookBySNButton";
            this.deleteBookBySNButton.Size = new System.Drawing.Size(206, 23);
            this.deleteBookBySNButton.TabIndex = 3;
            this.deleteBookBySNButton.Text = "Изтрий книгата";
            this.deleteBookBySNButton.UseVisualStyleBackColor = true;
            this.deleteBookBySNButton.Click += new System.EventHandler(this.deleteBookBySNButton_Click);
            // 
            // calculateBooksSumPanel
            // 
            this.calculateBooksSumPanel.Controls.Add(this.label7);
            this.calculateBooksSumPanel.Controls.Add(this.sumBooksTB);
            this.calculateBooksSumPanel.Controls.Add(this.calculateBooksSumButton);
            this.calculateBooksSumPanel.Location = new System.Drawing.Point(807, 80);
            this.calculateBooksSumPanel.Name = "calculateBooksSumPanel";
            this.calculateBooksSumPanel.Size = new System.Drawing.Size(215, 59);
            this.calculateBooksSumPanel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Сума на книгите";
            // 
            // sumBooksTB
            // 
            this.sumBooksTB.Location = new System.Drawing.Point(112, 3);
            this.sumBooksTB.MaxLength = 9999;
            this.sumBooksTB.Name = "sumBooksTB";
            this.sumBooksTB.ReadOnly = true;
            this.sumBooksTB.Size = new System.Drawing.Size(100, 20);
            this.sumBooksTB.TabIndex = 11;
            // 
            // calculateBooksSumButton
            // 
            this.calculateBooksSumButton.Location = new System.Drawing.Point(6, 29);
            this.calculateBooksSumButton.Name = "calculateBooksSumButton";
            this.calculateBooksSumButton.Size = new System.Drawing.Size(206, 23);
            this.calculateBooksSumButton.TabIndex = 3;
            this.calculateBooksSumButton.Text = "Намери Сума";
            this.calculateBooksSumButton.UseVisualStyleBackColor = true;
            this.calculateBooksSumButton.Click += new System.EventHandler(this.calculateBooksSumButton_Click);
            // 
            // findBookByAuthorPanel
            // 
            this.findBookByAuthorPanel.Controls.Add(this.label8);
            this.findBookByAuthorPanel.Controls.Add(this.searchAuthorTB);
            this.findBookByAuthorPanel.Controls.Add(this.authorBooksViewTB);
            this.findBookByAuthorPanel.Controls.Add(this.searchBookByAuthorButton);
            this.findBookByAuthorPanel.Location = new System.Drawing.Point(810, 146);
            this.findBookByAuthorPanel.Name = "findBookByAuthorPanel";
            this.findBookByAuthorPanel.Size = new System.Drawing.Size(215, 205);
            this.findBookByAuthorPanel.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Автор";
            // 
            // searchAuthorTB
            // 
            this.searchAuthorTB.Location = new System.Drawing.Point(112, 1);
            this.searchAuthorTB.MaxLength = 6;
            this.searchAuthorTB.Name = "searchAuthorTB";
            this.searchAuthorTB.Size = new System.Drawing.Size(100, 20);
            this.searchAuthorTB.TabIndex = 13;
            // 
            // authorBooksViewTB
            // 
            this.authorBooksViewTB.Location = new System.Drawing.Point(4, 54);
            this.authorBooksViewTB.Name = "authorBooksViewTB";
            this.authorBooksViewTB.ReadOnly = true;
            this.authorBooksViewTB.Size = new System.Drawing.Size(208, 148);
            this.authorBooksViewTB.TabIndex = 4;
            this.authorBooksViewTB.Text = "";
            // 
            // searchBookByAuthorButton
            // 
            this.searchBookByAuthorButton.Location = new System.Drawing.Point(4, 25);
            this.searchBookByAuthorButton.Name = "searchBookByAuthorButton";
            this.searchBookByAuthorButton.Size = new System.Drawing.Size(208, 23);
            this.searchBookByAuthorButton.TabIndex = 3;
            this.searchBookByAuthorButton.Text = "Намери книгите";
            this.searchBookByAuthorButton.UseVisualStyleBackColor = true;
            this.searchBookByAuthorButton.Click += new System.EventHandler(this.searchBookByAuthorButton_Click);
            // 
            // otherFunctionsPanel
            // 
            this.otherFunctionsPanel.Controls.Add(this.booksTo15PriceButton);
            this.otherFunctionsPanel.Controls.Add(this.booksТо150PagesButton);
            this.otherFunctionsPanel.Location = new System.Drawing.Point(811, 357);
            this.otherFunctionsPanel.Name = "otherFunctionsPanel";
            this.otherFunctionsPanel.Size = new System.Drawing.Size(215, 59);
            this.otherFunctionsPanel.TabIndex = 14;
            // 
            // booksTo15PriceButton
            // 
            this.booksTo15PriceButton.Location = new System.Drawing.Point(3, 3);
            this.booksTo15PriceButton.Name = "booksTo15PriceButton";
            this.booksTo15PriceButton.Size = new System.Drawing.Size(212, 23);
            this.booksTo15PriceButton.TabIndex = 4;
            this.booksTo15PriceButton.Text = "Намери книгите до 15 лв.";
            this.booksTo15PriceButton.UseVisualStyleBackColor = true;
            this.booksTo15PriceButton.Click += new System.EventHandler(this.booksTo15PriceButton_Click);
            // 
            // booksТо150PagesButton
            // 
            this.booksТо150PagesButton.Location = new System.Drawing.Point(3, 29);
            this.booksТо150PagesButton.Name = "booksТо150PagesButton";
            this.booksТо150PagesButton.Size = new System.Drawing.Size(212, 23);
            this.booksТо150PagesButton.TabIndex = 3;
            this.booksТо150PagesButton.Text = "Намери книгите до 150 страници";
            this.booksТо150PagesButton.UseVisualStyleBackColor = true;
            this.booksТо150PagesButton.Click += new System.EventHandler(this.booksТо150PagesButton_Click);
            // 
            // showSumRB
            // 
            this.showSumRB.AutoSize = true;
            this.showSumRB.Location = new System.Drawing.Point(309, 103);
            this.showSumRB.Name = "showSumRB";
            this.showSumRB.Size = new System.Drawing.Size(96, 17);
            this.showSumRB.TabIndex = 15;
            this.showSumRB.TabStop = true;
            this.showSumRB.Text = "Изчисли сума";
            this.showSumRB.UseVisualStyleBackColor = true;
            this.showSumRB.CheckedChanged += new System.EventHandler(this.showSumRB_CheckedChanged);
            // 
            // findBooksByAuthorRB
            // 
            this.findBooksByAuthorRB.AutoSize = true;
            this.findBooksByAuthorRB.Location = new System.Drawing.Point(309, 131);
            this.findBooksByAuthorRB.Name = "findBooksByAuthorRB";
            this.findBooksByAuthorRB.Size = new System.Drawing.Size(144, 17);
            this.findBooksByAuthorRB.TabIndex = 16;
            this.findBooksByAuthorRB.TabStop = true;
            this.findBooksByAuthorRB.Text = "Намери книги по автор";
            this.findBooksByAuthorRB.UseVisualStyleBackColor = true;
            this.findBooksByAuthorRB.CheckedChanged += new System.EventHandler(this.findBooksByAuthorRB_CheckedChanged);
            // 
            // otherFunctionsRB
            // 
            this.otherFunctionsRB.AutoSize = true;
            this.otherFunctionsRB.Location = new System.Drawing.Point(309, 159);
            this.otherFunctionsRB.Name = "otherFunctionsRB";
            this.otherFunctionsRB.Size = new System.Drawing.Size(102, 17);
            this.otherFunctionsRB.TabIndex = 17;
            this.otherFunctionsRB.TabStop = true;
            this.otherFunctionsRB.Text = "Други функции";
            this.otherFunctionsRB.UseVisualStyleBackColor = true;
            this.otherFunctionsRB.CheckedChanged += new System.EventHandler(this.otherFunctionsRB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.otherFunctionsRB);
            this.Controls.Add(this.findBooksByAuthorRB);
            this.Controls.Add(this.showSumRB);
            this.Controls.Add(this.otherFunctionsPanel);
            this.Controls.Add(this.findBookByAuthorPanel);
            this.Controls.Add(this.calculateBooksSumPanel);
            this.Controls.Add(this.deleteBookBySNPanel);
            this.Controls.Add(this.deleteBookRB);
            this.Controls.Add(this.showAllBooksRB);
            this.Controls.Add(this.addBookRB);
            this.Controls.Add(this.showAllBooksPanel);
            this.Controls.Add(this.viewGroupBox);
            this.Controls.Add(this.addBookPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Библиотека";
            ((System.ComponentModel.ISupportInitialize)(this.pagesCountBox)).EndInit();
            this.addBookPanel.ResumeLayout(false);
            this.addBookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            this.showAllBooksPanel.ResumeLayout(false);
            this.deleteBookBySNPanel.ResumeLayout(false);
            this.deleteBookBySNPanel.PerformLayout();
            this.calculateBooksSumPanel.ResumeLayout(false);
            this.calculateBooksSumPanel.PerformLayout();
            this.findBookByAuthorPanel.ResumeLayout(false);
            this.findBookByAuthorPanel.PerformLayout();
            this.otherFunctionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox storageNumberTB;
        private System.Windows.Forms.NumericUpDown pagesCountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel addBookPanel;
        private System.Windows.Forms.GroupBox viewGroupBox;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel showAllBooksPanel;
        private System.Windows.Forms.RichTextBox booksViewTB;
        private System.Windows.Forms.Button showAllBooksButton;
        private System.Windows.Forms.RadioButton addBookRB;
        private System.Windows.Forms.RadioButton showAllBooksRB;
        private System.Windows.Forms.RadioButton deleteBookRB;
        private System.Windows.Forms.Panel deleteBookBySNPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchStorageNumberTB;
        private System.Windows.Forms.Button deleteBookBySNButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sumBooksTB;
        private System.Windows.Forms.Button calculateBooksSumButton;
        private System.Windows.Forms.Panel findBookByAuthorPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchAuthorTB;
        private System.Windows.Forms.RichTextBox authorBooksViewTB;
        private System.Windows.Forms.Button searchBookByAuthorButton;
        private System.Windows.Forms.Panel otherFunctionsPanel;
        private System.Windows.Forms.Button booksTo15PriceButton;
        private System.Windows.Forms.Button booksТо150PagesButton;
        private System.Windows.Forms.RadioButton showSumRB;
        private System.Windows.Forms.RadioButton findBooksByAuthorRB;
        private System.Windows.Forms.RadioButton otherFunctionsRB;
        private System.Windows.Forms.Panel calculateBooksSumPanel;
    }
}


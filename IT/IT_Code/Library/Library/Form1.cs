using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        List<Book> libraryBooks = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            this.Width = 475;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in addBookPanel.Controls)
            {
                var textBox = control as TextBox;
                if (textBox != null && textBox.Text == string.Empty)
                {
                    MessageBox.Show("Непопълнени данни!");
                    return;
                }
            }
            libraryBooks.Add(new Book(
                storageNumberTB.Text,
                authorTB.Text,
                titleTB.Text,
                 Convert.ToUInt32(pagesCountBox.Value),
                Convert.ToDouble(priceBox.Value)
                ));

            foreach (Control control in addBookPanel.Controls)
            {
                var textBox = control as TextBox;
                if (textBox != null)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void showAllBooksButton_Click(object sender, EventArgs e)
        {
            booksViewTB.Text = string.Empty;
            libraryBooks.Select(book => book.ToString())
                       .ToList()
                       .ForEach(text => booksViewTB.Text += text);
        }

        private void deleteBookBySNButton_Click(object sender, EventArgs e)
        {
            libraryBooks.RemoveAll(book => book.StorageNumber == searchStorageNumberTB.Text);
            MessageBox.Show("Книгата бе изтрита");
        }

        private void calculateBooksSumButton_Click(object sender, EventArgs e)
        {
            sumBooksTB.Text = libraryBooks
                                .Select(book => book.Price)
                                .Sum()
                                .ToString();
        }

        private void searchBookByAuthorButton_Click(object sender, EventArgs e)
        {
            authorBooksViewTB.Text = string.Empty;
            libraryBooks.Where(book => book.Author==searchAuthorTB.Text)
                       .Select(book=>book.ToString())
                       .ToList()
                       .ForEach(text => authorBooksViewTB.Text += text);
        }

        private void booksTo15PriceButton_Click(object sender, EventArgs e)
        {
            var PriceTo15Books = libraryBooks.Where(book => book.Price <= 15).ToList();
            MessageBox.Show("OK");
        }

        private void booksТо150PagesButton_Click(object sender, EventArgs e)
        {
            var PriceTo15Books = libraryBooks
                                   .Where(book => book.PagesCount <= 150)
                                   .Select(book=> new { Author=book.Author, Price=book.Price})
                                   .ToList();
            MessageBox.Show("OK");
        }

        private void otherFunctionsRB_CheckedChanged(object sender, EventArgs e)
        {
            ChangePanel(otherFunctionsPanel);
        }

        private void findBooksByAuthorRB_CheckedChanged(object sender, EventArgs e)
        {
            ChangePanel(findBookByAuthorPanel);
        }

        private void showSumRB_CheckedChanged(object sender, EventArgs e)
        {
            ChangePanel(calculateBooksSumPanel);
        }

        private void deleteBookRB_CheckedChanged(object sender, EventArgs e)
        {
            ChangePanel(deleteBookBySNPanel);
        }

        private void showAllBooksRB_CheckedChanged(object sender, EventArgs e)
        {
            ChangePanel(showAllBooksPanel);
        }

        private void addBookRB_CheckedChanged(object sender, EventArgs e)
        {
            ChangePanel(addBookPanel);
        }

        private void ChangePanel(Panel newPanel)
        {
            viewGroupBox.Controls.Clear();
            viewGroupBox.Controls.Add(newPanel);
            viewGroupBox.Controls[0].Location = viewGroupBox.Location;
        }
    }
}

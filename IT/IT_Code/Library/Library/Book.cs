using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class Book
    {
        public readonly string StorageNumber;
        public string Author { get; set; }
        public string Title { get; set; }

        public readonly uint PagesCount;
        public double Price { get; set; }

        public Book(string StorageNumber, string Author, string Title, uint PagesCount,double Price)
        {
            this.StorageNumber = StorageNumber;
            this.Author = Author;
            this.Title = Title;
            this.PagesCount = PagesCount;
            this.Price = Price;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"Автор: {this.Author}");
            result.AppendLine($"Заглавие: {this.Title}");
            result.AppendLine($"Брой страници: {this.PagesCount}");
            result.AppendLine($"Цена: {this.Price:0.00} лв.");
            result.AppendLine(new string('-',10));

            return result.ToString();
        }
    }
}

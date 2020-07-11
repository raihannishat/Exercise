using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_7_3
{
    public class Book
    {
        private string name;
        private Author author;
        private int price;
        private int stock;

        public Book(string name, Author author, int price, int stock)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.stock = stock;
        }

        public string getName()
        {
            return name;
        }

        public string getAuthor()
        {
            return author.getName();
        }

        public int getPrice()
        {
            return price;
        }

        public int getStock()
        {
            return stock;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAuthor(Author author)
        {
            this.author = author;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queston1_LabEx4
{
    public abstract class Book
    {
        protected string bookTitle;
        protected double Price;

        public Book(string bookTitle)
        {
            this.bookTitle = bookTitle;
            Price = 0;
        }

        public string Title { get { return bookTitle; } }
        public double BookPrice { get { return Price; } }

        public abstract void setPrice();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queston1_LabEx4
{
    public class Non_Fiction : Book
    {
        public Non_Fiction(string bookTitle) : base(bookTitle)
        {
            this.bookTitle = bookTitle;
        }

        public override void setPrice()
        {
            Price = 230;
        }
    }
}

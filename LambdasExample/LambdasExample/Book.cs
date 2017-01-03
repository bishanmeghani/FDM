using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasExample
{
    public class Book
    {
        public string title { get; set; }
        public int numberOfPages { get; set; }


        public Book(string Title, int NumberOfPages)
        {
            title = Title;
            numberOfPages = NumberOfPages;

        }
    }
}

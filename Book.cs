using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Book
    {
        

        public string Name { get; set; }
        public string Author { get; set; }
        public int YearOfRelease { get; set; }

        public Book()
        {
            
        }
        public Book(string name, string author, int yearOfRelease)
        {
            Name = name;
            Author = author;
            YearOfRelease = yearOfRelease;
        }

    }
}

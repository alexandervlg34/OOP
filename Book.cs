using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Book
    {
        private string name;
        private string author;
        private int yearOfRelease;

        public string Name {  get { return name; } }
        public string Author { get { return author; } }
        public int YearOfRelease {  get { return yearOfRelease; } }

        public Book()
        {
            
        }
        public Book(string name, string author, int yearOfRelease)
        {
            this.name = name;
            this.author = author;
            this.yearOfRelease = yearOfRelease;
        }

    }
}

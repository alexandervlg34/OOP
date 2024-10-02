using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BookDepository
    {
        public List<Book> books = new List<Book>();

        Book book1 = new Book("The Lord of the Rings", "Tolkien", 1954);
        Book book2 = new Book("The Hobbit, or There and Back Again", "Tolkien", 1937);
        Book book3 = new Book("Ferrari. Meet the Legend", "Saverio Villa", 2020);


        public void CreateBookDepository()
        {
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void ShowAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.Name);
                Console.WriteLine(book.Author);
                Console.WriteLine(book.YearOfRelease);
            }
        }

        public void ShowBookByName(string name)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Name == name)
                {
                    Console.WriteLine(books[i].Name);
                    Console.WriteLine(books[i].Author);
                    Console.WriteLine(books[i].YearOfRelease);
                }
            }
        }

        public void ShowBookByAuthor(string author)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Author == author)
                {
                    Console.WriteLine(books[i].Name);
                    Console.WriteLine(books[i].Author);
                    Console.WriteLine(books[i].YearOfRelease);
                }
            }
        }

        public void ShowBookByYearOfRelease(int yearOfRelease)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].YearOfRelease == yearOfRelease)
                {
                    Console.WriteLine(books[i].Name);
                    Console.WriteLine(books[i].Author);
                    Console.WriteLine(books[i].YearOfRelease);
                }
            }
        }

    }
}

using Practica_2_POO.Lista.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_POO.Lista.Servicios
{
    public class BookService : IBooksService
    {    
        List<Book> books = new List<Book>();

        public List<Book> GetBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            Book booksearch = books.Find((item) => item.Id == id);

            return booksearch;


        }


        public Book addBook(Book book)
        {
            book.Id = books.Count + 1;

            books.Add(book);

            return book;
        }



        public void deleteBook(int id)
        {

         Book booksearch = books.Find((item) => item.Id == id);

            books.Remove(booksearch);

        }


        

        public Book updateBook(int id, Book book)
        {

            Book booksearch = books.Find((item) => item.Id == id);

            booksearch.Name = book.Name;
            booksearch.Description = book.Description;

            return booksearch;
        }
    }
}

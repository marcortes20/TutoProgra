using Practica_2_POO.Lista.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_POO.Lista.Servicios
{
    public interface IBooksService
    {

        public List<Book> GetBooks();

        public Book GetBookById(int id);

        public Book addBook( Book book);
        public void deleteBook(int id);

        public Book updateBook(int id,Book book);

    }
}

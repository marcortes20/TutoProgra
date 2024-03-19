// See https://aka.ms/new-console-template for more information
using Practica_2_POO.Lista.Entidades;
using Practica_2_POO.Lista.Servicios;
using static System.Reflection.Metadata.BlobBuilder;




Book book = new Book { 

    Name = "Pinocho",
    Description = "Libro infantil",

};

Book book1 = new Book
{

    Name = "Pitagoras",
    Description = "Libro matematico",

};


Book book2 = new Book
{

    Name = "Paco y loca",
    Description = "Libro educativo",

};


BookService bookService = new BookService();

bookService.addBook(book);
bookService.addBook(book1);
bookService.addBook(book2);





void printList(List<Book> lista)
{
    Console.WriteLine("\t \t Lista:");

    lista.ForEach((item) =>
    {
       
        Console.WriteLine(item.Id);
        Console.WriteLine(item.Name);
        Console.WriteLine(item.Description);
        Console.WriteLine("\n");


    } );

}
printList(bookService.GetBooks());



Console.WriteLine("\nLista con uno eliminado");
bookService.deleteBook(2);
printList(bookService.GetBooks());

Book editedBook = new Book
{
    Name = "nombre nuevo",
    Description = "Nueva descri....",
};

Console.WriteLine("\nLista con uno eliminado y otro editado");
bookService.updateBook(3, editedBook);
printList(bookService.GetBooks());
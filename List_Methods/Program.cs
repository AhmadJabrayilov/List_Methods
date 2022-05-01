using List_Methods.Models;
using System;

namespace List_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("1984", "George Orwell", 220);

            Book book2 = new Book("Metro 2033", "Dimitri Gulyuxovski", 540);

            Book book3 = new Book("Birinci addim", "Orxan Zeynalli", 245);

            Book book4 = new Book("Reqemsal meshe", "Orxan Zeynalli", 300);

            Book book5 = new Book("Heyvanistan", "George  Orwell", 140);

            Book book6 = new Book("Yeraltindan notlar", "Dostaevski", 670);

            Book book7 = new Book("Korluq", "Jose Saramago", 410);


            Library library = new Library();

            Console.WriteLine(library.FindAllBooksByName("a"));




            foreach (var book in library.SearchBooks("a"))
            {
                Console.WriteLine(book.Name);


            }





        }
    }
}

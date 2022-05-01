using System;
using System.Collections.Generic;
using System.Text;

namespace List_Methods.Models
{
    internal class Library
    {
        List<Book> Books = new List<Book>();

        

        public List<Book> FindAllBooksByName(string value)
        {
            return Books.FindAll(book => book.Name.Contains(value));
        }

        public void RemoveAllBooksByNme(string value)
        {
            Books.RemoveAll(book => book.Name.Contains(value));
        }

        public  List<Book> SearchBooks(string value)
        {
            return Books.FindAll(book => book.Name.Contains(value) || book.AuthorName.Contains(value) || book.PageCount.ToString().Contains(value));
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return Books.FindAll(book => book.PageCount >= min && book.PageCount <= max);
        }

        public void RemoveBookByCode(string value)
        {

            Book removeBook = Books.Find(book => book.Code == value);

            if(removeBook != null)
            {
                Books.Remove(removeBook); 
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace List_Methods.Models
{
    internal class Book
    {
        private static int _bookId;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public int BookId { get; set; }

        public Book(string name, string authorName, int pageCount)
        {
            BookId = ++_bookId;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = Name.Substring(0, 2).ToUpper() + BookId;            
        }


    }
}

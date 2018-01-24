using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLabDll
{
    public class BookLib
    {
        List<Book> list = null;

        public BookLib()
        {
            list = new List<Book>(); 
        }

        // Existed: false - Not existed: 
        public Book checkExisted(string id)
        {
            foreach (var book in list)
            {
                if (book.Id.Equals(id))
                {
                    return book; 
                }
            }
            return null; 
        }
        public bool addBook(Book book)
        {
            Book existed = checkExisted(book.Id);
            if (existed != null)
            {
                return false;
            }
                        
            list.Add(book);
            return true; 
                        
        }

        // true: success - false: fail 
        // Remove Book by Id
        public bool removeBook(string id)
        {
            Book existedBook = checkExisted(id);
            if (existedBook == null)
            {
                return false; 
            }
            list.Remove(existedBook);

            return true;
        }
        public List<Book> findBook(string name)
        {
            List<Book> books = new List<Book>();
            foreach(var book in list)
            {
                if (book.Name.ToLower().Contains(name.ToLower()))
                {
                    books.Add(book);
                }
            }
            return books;
        }

        public void printListBook()
        {
            foreach (var book in list)
            {
                Console.WriteLine(book.ToString());
            }
        }


    }
}

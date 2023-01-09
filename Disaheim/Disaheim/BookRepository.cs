using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            Book b = null;
            
            foreach(Book book in books)
            {
                if(book.ItemId == itemId)
                {
                    b = book;
                }
            }

            return b;
        }

        public double GetTotalValue()
        {

            double totalValue = 0;

            if(books != null)
            {
                foreach(Book book in books)
                {
                    totalValue += book.Price;
                }
            }

            return totalValue;  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        public List<Book> Books { get; set; }
        public List<Amulet> Amulets { get; set; }

        public Controller()
        {

        }

        public void addToList(Book book)
        {
            Books.Add(book);
        }


        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);    
        }

    }
}

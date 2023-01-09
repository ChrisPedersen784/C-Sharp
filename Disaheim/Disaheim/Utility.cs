using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {


            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            double price;
            if (amulet.Quality == Level.low)
            {
                price = 12.5;

            }
            else if (amulet.Quality == Level.medium)
            {
                price = 20.0;
            }
            else
            {
                price = 27.5;
            }

            return price;
        }
    }
}

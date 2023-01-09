using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

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




        public double GetValueOfCourse(Course course)
        {
            int result = (course.DurationInMinutes / 60);

            if (course.DurationInMinutes % 60 != 0 && course.DurationInMinutes > 0)
            {
                result++;
                result *= 875;

            }
            else if (course.DurationInMinutes % 60 == 0)
            {
                result *= 875;
            }

            else
            {
                course.DurationInMinutes = 0;
            }


            return result;

        }
    }
}

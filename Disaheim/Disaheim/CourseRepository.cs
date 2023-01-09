using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            Course c = null;

           foreach(var course in courses)
            {
                if(course.Name == name)
                {
                    c = course;
                }
            }

            return c;
        }

        public double GetTotalValue()
        {
            double TotalValue = 0;
            var u = new Utility();

            foreach(var course in courses)
            {
                TotalValue += u.GetValueOfCourse(course);
            }

            return TotalValue;  

        }

    }
}

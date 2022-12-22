using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCodeCourses
{
    internal class Courses
    {
        string course;
        
        public Courses(string course)
        {
            this.course = course;
        }

       

        public int validate()
        {

            int result = -1;
            if (this.course.Length == 2)
            {
                if (int.TryParse(this.course, out result))
                {
                    return result;
                }
                return -1;
            }
            return -1;
        }
        public string getCourse()
        {
            return this.course;
        }
        public string selectCourse(List<Courses> course, int position)
        {
            return course[position].getCourse();
        }
    }
}

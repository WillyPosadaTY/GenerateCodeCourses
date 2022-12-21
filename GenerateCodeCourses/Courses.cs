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


        public int validate(string courseNum)
        {

            int result = -1;
            if (courseNum.Length == 2)
            {
                if (int.TryParse(courseNum, out result))
                {
                    return result;
                }
                return -1;
            }
            return -1;
        }
    }
}

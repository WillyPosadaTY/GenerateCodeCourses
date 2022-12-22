using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCodeCourses
{
    internal class Teachers
    {
        string teacher;
        
        public Teachers(string teacher)
        {
            this.teacher = teacher;
        }
        public string getTitle()
        {
            var title = this.teacher.Split(" ");
            return title[0];
        }
        public string getName()
        {
            var titleName = this.teacher.Split(" ");
            var name = "";
            titleName = titleName.Where((item, index) => index != 0).ToArray();
            foreach (string names in titleName)
            {
                name += String.Join(" ", names)+" ";
            }
            return name;
        }

        
        public string getTitleInvested()
        {
            string reverse = new string(getTitle().Reverse().ToArray());
            return reverse;
        }

        
        public string getLastLetter()
        {
            string letter = "";
            string[] nameTeacher = getName().Split(" ");
            foreach (string letters in nameTeacher)
            {
                try 
                {
                    letter += letters.Substring(letters.Length - 1, 1);
                } 
                catch
                {

                }
            }
            return letter;
        }

        public Teachers selectTeacher(List<Teachers> teacher, int position)
        {
            return teacher[position];
        }






    }
}

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
        string title;
        string name;
        
        public Teachers(string title, string name)
        {
            this.title = title;
            this.name = name;
        }
        public string getTitle()
        {
            return this.title;
        }
        public string getName()
        {
            return this.name;
        }

        
        public string getTitleInvested()
        {
            string reverse = new string(getTitle().Reverse().ToArray());
            return reverse;
        }

        
        public string getLastLetter()
        {
            string letter = "";
            string[] nameTeacher = this.name.Split(" ");
            foreach (string letters in nameTeacher)
            {
                letter += letters.Substring(letters.Length - 1, 1);
            }
            return letter;
        }






    }
}

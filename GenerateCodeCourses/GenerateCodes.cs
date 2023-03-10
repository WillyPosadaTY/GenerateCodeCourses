using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCodeCourses
{
    internal class GenerateCodes
    {
        string course;
        string teacher;
        string period;
        int students;

        public GenerateCodes(string course, string teacher, string period, int students)
        {
           this.course= course;
           this.teacher= teacher;
           this.period= period;
           this.students= students;
        }

        public string generateCodes()
        {
            string nombres = "";
            string cantSpaces = this.students.ToString();
            int spaces = cantSpaces.Length;
            string cadena = "";
            string pivote = "";
            for(int i = 1; i < spaces; i++)
            {
                cadena += "0";
            }
            for(int i = 1; i <= this.students; i++)
            {
                pivote = cadena + i;
                
                try
                {
                    nombres += this.course + this.teacher.ToUpper() + '-' + this.period + pivote.Substring(pivote.Length- spaces) + '\n';
                }
                catch (ArgumentOutOfRangeException argumentOutOfRangeException)
                {
                   Console.WriteLine($"Error: {argumentOutOfRangeException.Message}");
                }
            }
            return nombres;
        }

    }
}

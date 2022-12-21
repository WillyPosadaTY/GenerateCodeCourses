// See https://aka.ms/new-console-template for more information
using GenerateCodeCourses;
using System.ComponentModel.DataAnnotations;
string course;
string title;
string name;

Console.WriteLine("Ingrese el número del curso Ej: 00, 01,..., 99");
course = Console.ReadLine();

Courses courses = new Courses(course);

int courseVal = courses.validate(course);

while (courseVal < 0) {
    Console.WriteLine("Ingrese un número de curso válido");
    course = Console.ReadLine();
    courseVal = courses.validate(course);
}
Console.WriteLine("el codigo del curso es DCC"+ courseVal);
Console.WriteLine("Ingrese el título del profesor Ej: PhD, MD, MSc, ect...");

title = Console.ReadLine();
Console.WriteLine("Ingrese el nombre del profesor");
name = Console.ReadLine();
Console.WriteLine("profesor es: " + title +' '+ name);








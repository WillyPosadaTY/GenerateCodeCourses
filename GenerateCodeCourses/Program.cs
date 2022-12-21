// See https://aka.ms/new-console-template for more information
using GenerateCodeCourses;
using System.ComponentModel.DataAnnotations;

/**
 * Variables de almacenamiento
 * 
 */
string course;
string title;
string name;
string year;
string type;
string number;

/**
 * Captura información de curso
 */

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

/**
 * Captura información de profesor
 */
Console.WriteLine("Ingrese el título del profesor Ej: PhD, MD, MSc, ect...");

title = Console.ReadLine();
Console.WriteLine("Ingrese el nombre del profesor");
name = Console.ReadLine();

Teachers teacher = new Teachers(title, name);


Console.WriteLine("El profesor es: " + teacher.getTitle() + ' ' + teacher.getName());
Console.WriteLine("El código inverido es: " + teacher.getTitleInvested());
Console.WriteLine("últimas letras profesor: " + teacher.getLastLetter());
/**
 * Captura información de periodo
 */
Console.WriteLine("Ingrese año");
year = Console.ReadLine();

Periods years = new Periods();

int yearVal = years.validateYear(year);

while (yearVal < 0)
{
    Console.WriteLine("Ingrese un número de año válido");
    year = Console.ReadLine();
    yearVal = years.validateYear(year);
}
Console.WriteLine("Ingrese periodo: (Mes: M, Trimestre: Q y Semestre: S)");

type = Console.ReadLine();

Periods types = new Periods();

char typeVal = types.validateType(type);

while (typeVal.Equals('N'))
{
    Console.WriteLine("Ingrese un periodo válido: M, S, Q");
    type = Console.ReadLine();
    typeVal = types.validateType(type);
}

Console.WriteLine("Ingrese periodo: (Mes del 1 al 10, Trimestre del 1 al 3 y Semestre 1 o 2)");

number = Console.ReadLine();

Periods numbers = new Periods();

int numberVal = numbers.validateNumber(number, types.getMaxPeriod());

Console.WriteLine(numberVal+"------------");
while (numberVal < types.getMaxPeriod())
{
    Console.WriteLine("Ingrese un número válido para el periodo: M 1..10, S 1,2, Q 1..3");
    number = Console.ReadLine();
    numberVal = numbers.validateNumber(number, types.getMaxPeriod());
}
Console.WriteLine("Periodo: "+yearVal+typeVal+numberVal);








// See https://aka.ms/new-console-template for more information
using GenerateCodeCourses;
using System.ComponentModel.DataAnnotations;

/**
 * Storage variables
 * 
 */
string course;
string teacher;
string period;
string type;
string number;
string codeTeacher;
string codeTeacherSelected;
string codeCourse;
string codePeriod;
string validatorNewCourse = "1";
string validatorNewTeacher = "1";
string validatorNewPeriod = "1";
List<Courses> coursesList = new List<Courses> { };
List<Teachers> teachersList = new List<Teachers> { };
List<Periods> periodList = new List<Periods> { };

int iteratorCourse = 0;
int iteratorTeacher = 0;
int iteratorPeriod = 0;
/**
 * Capture course information
 */

Console.WriteLine("Ingrese el número del curso Ej: 00, 01,..., 99");
course = Console.ReadLine();

Courses courses = new Courses(course);

int courseVal = courses.validate();

while (courseVal < 0) {
    Console.WriteLine("Ingrese un número de curso válido");
    course = Console.ReadLine();
    courses = new Courses(course);
    courseVal = courses.validate();
}
Console.WriteLine("el codigo del curso es DCC"+ course);
codeCourse = "DCC" + course;
coursesList.Add(courses);
while (validatorNewCourse == "1")
{
    Console.WriteLine("¿Desea agregar un nuevo curso? Sí = 1, No = Cualquier tecla");
    validatorNewCourse = Console.ReadLine();
    if (validatorNewCourse == "1")
    {
        Console.WriteLine("Ingrese el número del curso Ej: 00, 01,..., 99");
        course = Console.ReadLine();

        courses = new Courses(course);

        courseVal = courses.validate();

        while (courseVal < 0)
        {
            Console.WriteLine("Ingrese un número de curso válido");
            course = Console.ReadLine();
            courses = new Courses(course);
            courseVal = courses.validate();
        }
        Console.WriteLine("el codigo del curso es DCC" + course);
        codeCourse = "DCC" + course;
        coursesList.Add(courses);
    }

}
Console.WriteLine("Los cursos son los siguientes:\n");
foreach (Courses cour in coursesList)
{
    Console.Write(cour.getCourse()+"\n");
}

/**
 * Capture teacher information
 */
Console.WriteLine("Ingrese el título y el nombre del profesor Ej: PhD Xavi Puig Gaudí, MD Thiago dos Santos Soares, ect...");
teacher = Console.ReadLine();

Teachers teachers = new Teachers(teacher);

Console.WriteLine("El profesor es: " + teachers.getTitle() + ' ' + teachers.getName());
Console.WriteLine("El código inverido es: " + teachers.getTitleInvested());
Console.WriteLine("últimas letras profesor: " + teachers.getLastLetter());
codeTeacher = teachers.getTitleInvested();
codeTeacher += teachers.getLastLetter();
teachersList.Add(teachers);

while (validatorNewTeacher == "1")
{
    Console.WriteLine("¿Desea agregar un nuevo profesor? Sí = 1, No = Cualquier tecla");
    validatorNewTeacher = Console.ReadLine();
    if (validatorNewTeacher == "1")
    {
        Console.WriteLine("Ingrese el título y el nombre del profesor Ej: PhD Xavi Puig Gaudí, MD Thiago dos Santos Soares, ect...");
        teacher = Console.ReadLine();

        teachers = new Teachers(teacher);
        Console.WriteLine("El profesor es: " + teachers.getTitle() + ' ' + teachers.getName());
        Console.WriteLine("El código inverido es: " + teachers.getTitleInvested());
        Console.WriteLine("últimas letras profesor: " + teachers.getLastLetter());
        codeTeacher = teachers.getTitleInvested();
        codeTeacher += teachers.getLastLetter();
        teachersList.Add(teachers);
    }

}
Console.WriteLine("Los profesores son los siguientes:\n");
foreach (Teachers tea in teachersList)
{
    Console.Write(tea.getTitle() + ' ' + tea.getName() + "\n");
}
/**
 *Capture period information
 */
Console.WriteLine("Ingrese un periodo: Año + sección del año + número de sección\nPara M máximo 10, Para Q 3 y para S 2");
period = Console.ReadLine();

Periods periods = new Periods(period);

bool yearVal = periods.validatePeriod();

while(yearVal == false)
{
    Console.WriteLine("Ingrese un periodo válido: Año + sección del año + número de sección\nPara M máximo 10, Para Q 3 y para S 2");
    period = Console.ReadLine();
    periods = new Periods(period);
    yearVal = periods.validatePeriod();
}
periodList.Add(periods);

while (validatorNewPeriod == "1")
{
    Console.WriteLine("¿Desea agregar un nuevo periodo? Sí = 1, No = Cualquier tecla");
    validatorNewPeriod = Console.ReadLine();
    if (validatorNewPeriod == "1")
    {
        Console.WriteLine("Ingrese un periodo válido: Año + sección del año + número de sección\nPara M máximo 10, Para Q 3 y para S 2");
        period = Console.ReadLine();
        periods = new Periods(period);
        yearVal = periods.validatePeriod();
        while (yearVal == false)
        {
            Console.WriteLine("Ingrese un periodo válido: Año + sección del año + número de sección\nPara M máximo 10, Para Q 3 y para S 2");
            period = Console.ReadLine();
            periods = new Periods(period);
            yearVal = periods.validatePeriod();
        }
        periodList.Add(periods);
    }

}
Console.WriteLine("Los periodos son los siguientes:\n");
foreach (Periods per in periodList)
{
    Console.Write(per.getPeriod() +  "\n");
}

Console.WriteLine("Seleccione un curso de los listados a continuación: ");
Console.WriteLine("Los cursos son los siguientes:\n");
foreach (Courses cour in coursesList)
{
    Console.Write(iteratorCourse + " DCC"+ cour.getCourse()+"\n");
    iteratorCourse++;
}
int findCourse = Convert.ToInt32(Console.ReadLine());
string courseSelect = courses.selectCourse(coursesList, findCourse);
Console.WriteLine("Curso Seleccionado :DCC"+ courseSelect);

Console.WriteLine("Seleccione un profesor de los listados a continuación: ");
Console.WriteLine("Los profesores son los siguientes:\n");
foreach (Teachers tea in teachersList)
{
    Console.Write(iteratorTeacher + " " + tea.getTitle() + " " + tea.getName() + "\n");
    iteratorTeacher+=1;
}
int findTeacher = Convert.ToInt32(Console.ReadLine());
Teachers teacherSelect = teachers.selectTeacher(teachersList, findTeacher);
Console.WriteLine("El profesor seleccionado es:"+ teacherSelect.getTitle()+" "+teacherSelect.getName());

Console.WriteLine("Seleccione un periodo de los listados a continuación: ");
Console.WriteLine("Los periodos son los siguientes:\n");
foreach (Periods per in periodList)
{
    Console.Write(iteratorPeriod + " " + per.getPeriod() + "\n");
    iteratorPeriod++;
}
int findPeriod = Convert.ToInt32(Console.ReadLine());
Periods periodSelect = periods.selectPeriod(periodList, findPeriod);
Console.WriteLine("El periodo seleccionado es:"+ periodSelect.getPeriod());
Console.WriteLine("Escriba el # de estudiantes: ");


int numberOfCodes = Convert.ToInt32(Console.ReadLine());
codeTeacherSelected = teacherSelect.getTitleInvested();
codeTeacherSelected += teacherSelect.getLastLetter();

GenerateCodes exam = new GenerateCodes(courseSelect, codeTeacherSelected, periodSelect.getPeriod(), numberOfCodes);
string nombres = exam.generateCodes();
Console.WriteLine(nombres);







using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var s = new Student("Alex");
           
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko",new Knowledge(1111)));
            university.AddStudent(new Student("Julia Veselkina", new Knowledge(160)));
            university.AddStudent(new Student("Maria Perechrest", new Knowledge(180)));
            university.AddStudent(new Student("Alex", new Knowledge(180)));

            Internship internship = new Internship("Interlink");
            internship.AddUniversity(university);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}

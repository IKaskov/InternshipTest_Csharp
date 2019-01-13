using InternshipTest.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace internshiptest
{
    public interface IStrategy
    {
        List<Student> GetStudents();
    }
}

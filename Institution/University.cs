using internshiptest;
using InternshipTest.Person;
using System.Collections.Generic;
using System.Linq;

namespace InternshipTest.Institution
{
    public class University
    {
        List<Student> Students = new List<Student>();

        private IStrategy strategy;

        public University(string name)
        {
            //TODO: Implementation is needed  
            Name = name;
        }

        public string Name { get; private set; }

        public void AddStudent(Student student)
        {
            //TODO: Implementation is needed
            Students.Add(student);
        }

        public void AddStudent(params Student[] students)
        {
            Students.AddRange(students);
        }
        
        public void AddStudent()
        {
            Students.AddRange(strategy.GetStudents());
        }

        public IStrategy Strategy { set { strategy = value; } }

        //public void SetStrategy(IStrategy strategy)
        //{
        //    this.strategy = strategy;
        //}

        public List<Student> GetStudentsWithEnoughtKnowledge()
        {
            var avg = (from stud in Students
                       where stud.Knowledge.Level!=null
                       select stud.Knowledge.Level).Average();

            var s = (from stud in Students
                     where stud.Knowledge.Level >= avg
                     select stud).ToList();

            return s;
        }
    }
}

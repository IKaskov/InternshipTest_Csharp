using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        List<University> Universities = new List<University>();

        public Internship(string name)
        {
            //TODO: Implementation is needed   
            Name = name;
        }

        public string Name { get; private set; }

        public void AddUniversity(University university)
        {
            Universities.Add(university);
        }

        public void AddUniversity(params University[] universities)
        {
            Universities.AddRange(universities);
        }

        public string GetStudents()
        {
            //TODO: Implementation is needed

            string res = string.Empty;

            foreach (var un in Universities)
            {
                foreach (var st in un.GetStudentsWithEnoughtKnowledge())
                    res += st.Name+"\n";
            }

            return res;
        }
    }
}

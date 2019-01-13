namespace InternshipTest.Person
{
    public class Student
    {
        public Student(string name)
        {
            //TODO: Implementation is needed
            Name = name;
        }

        public Student(string name, Knowledge knowledge)
            : this(name)
        {
            Knowledge = knowledge;
        }

        public string Name { get; private set; }

        public Knowledge Knowledge { get; private set; }

        //public void SetKnowledge(Knowledge knowledge)
        //{
        //    //TODO: Implementation is needed
        //}

        public override string ToString()
        {
            return Name;
        }
    }
}
namespace InternshipTest
{
    public class Knowledge
    {
        int? level;
        public Knowledge(int level)
        {
            //TODO: Implementation is needed
            Level = level;
        }

        public int? Level
        {
            get { return level; }
            private set
            {
                if (value > 0 && value <= 200)
                    level = value;
            }

        }
    }
}


namespace Wk5APIE
{
    public abstract class Antique
    {
        //Fields
        //public int time; // Do what you want with this field and get time w.e
        //private int counter; //ONLY use counter IN this class

        //Attributes OR properties
        //public int Count { get; } //Read only property

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative");
                }
                _age = value;
            }
        }
        //public int Age { get; set; }
        public string Condition { get; set; } 
        public double Value { get; set; }
        public string Description { get; set; }

        public Antique(int age, string cond, double value, string desc)
        {
            Age = age;
            Condition = cond;
            Value = value;
            Description = desc;
        }

        public abstract void PrintDetails();
    }
}

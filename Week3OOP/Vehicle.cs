
namespace Week3OOP
{
    //BASE PARENT CLASS
    public abstract class Vehicle
    {
        //AUTO PROPERTY
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int MaxSpeed { get; set; }

        private int _speedLimit = 80;

        //SEATS, WINDOWS, DOORS, ETC

        public Vehicle(string make, string model, int mxSpd) 
        {
            Make = make;
            Model = model;
            MaxSpeed = mxSpd;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"The {Make} {Model} has a top speed of {MaxSpeed} kph.");
        }
        public virtual void PrintDetails(string msg)
        {
            Console.WriteLine($"The {Make} {Model} has a top speed of {MaxSpeed} kph.");
        }

        //Override AND Overload
        public abstract void Drive();
        public abstract void Drive(int currSpd);
        public virtual int CheckSpeedLimit()
        {
            return _speedLimit;
        }

    }
}

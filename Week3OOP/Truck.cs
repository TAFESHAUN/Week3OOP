

namespace Week3OOP
{
    class Truck : Vehicle
    {
        public Truck(string make, string model, int mxSpd) : base(make, model, mxSpd)
        {

        }

        public override void Drive()
        {
            Console.WriteLine("The Truck is driving");
        }

        public override void Drive(int currSpd)
        {
            Console.WriteLine($"The Truck is driving at {currSpd} kph");
        }
    }
}

//USING -> IMPORTS


namespace Week3OOP
{
    public class Car: Vehicle
    {

        //CONSTRUCTOR
        public Car(string make, string model, int mxSpd):base(make, model, mxSpd)
        {

        }

        //Do something different from other vehicles
        //Ovveride the base class method for PRINTDETAILS
        public override void PrintDetails()
        {
            //base.PrintDetails();
            Console.WriteLine($"The Car does things differently and it is a " +
                $"{Make} {Model} has a top speed of {MaxSpeed} kph.");
        }
    }
}


//FULL PROPERTY MANUAL
//private string _make;
//public string Make
//{
//    get { return _make; }
//    set { _make = value; }
//}

//Flat property
//string model;
//int maxSpeed;
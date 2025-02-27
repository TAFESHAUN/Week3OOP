//USING -> IMPORTS


namespace Week3OOP
{
    public class Car: Vehicle
    {

        //CONSTRUCTOR
        public Car(string make, string model, int mxSpd) : base(make, model, mxSpd) 
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

        public override void Drive()
        {
            Console.WriteLine("The Car is driving");
        }

        public override void Drive(int currSpd)
        {
            int speedLimit = CheckSpeedLimit();
            if (currSpd > speedLimit)
            {
                Console.WriteLine($"The cops are comming!!!!" +
                    $"The Car is driving at {currSpd} kph");

            }
            else
            {
                Console.WriteLine($"We are following the {speedLimit}kph speed limit." +
                    $"The Car is driving at {currSpd} kph");
            }
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
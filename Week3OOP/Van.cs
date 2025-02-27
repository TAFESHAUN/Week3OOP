namespace Week3OOP
{
    class Van : Vehicle
    {
        public bool HasSlidingDoor { get; set; }
        public int NumberOfSlidingDoors { get; set; }

        public Van(string make, string model, int mxSpd, bool hasSlidingDoor, int numberOfSlidingDoors) : base(make, model, mxSpd)
        {
            HasSlidingDoor = hasSlidingDoor;
            NumberOfSlidingDoors = numberOfSlidingDoors;
        }

        public override void PrintDetails()
        {
            if (HasSlidingDoor == true)
            {
                Console.WriteLine($"The Van doors can slide! There is {NumberOfSlidingDoors} of sliding doors." +
                    $"The {Make} {Model} has a top speed of {MaxSpeed} kph.");
            }
            else
            {
                Console.WriteLine($"The Van doors do not slide :(. There is no slidings doors that sucks!" +
                    $"The {Make} {Model} has a top speed of {MaxSpeed} kph.");
            }
            
        }

        public override void Drive()
        {
            Console.WriteLine("The Van is driving");
        }

        public override void Drive(int currSpd)
        {
            int speedLimit = CheckSpeedLimit();
            if (currSpd > speedLimit)
            {
                Console.WriteLine($"The cops are comming!!!!" +
                    $"The Van is driving at {currSpd} kph");

            }
            else
            {
                Console.WriteLine($"We are following the {speedLimit}kph speed limit." +
                    $"The Van is driving at {currSpd} kph");
            }
        }
    }
}

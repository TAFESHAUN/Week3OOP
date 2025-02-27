using Week3OOP;
using System.Collections.Generic;

//LIST OF VEHICLES
List<Vehicle> vehicles = new List<Vehicle>(); //Literal defaults later

//We need a better indication of the total number of vehicles
//Menu to add vehicles to list organically
//Add,remove update vehicles, print all etc, exit

//OBJECTS GO HERE
Car Ford = new Car("Mustang","GT",205);
Truck FordTruck = new Truck("F-150", "Raptor", 180);
//Ford.Make = "Mustang";
//Ford.Model = "GT";
//Ford.MaxSpeed = 205;

//Wk 4 Objects
Van toyotaVan = new Van("Toyota", "Hiace", 160, true, 2);
Van ldvVan = new Van("LDV", "V80", 160, false, 0);

vehicles.Add(Ford);
vehicles.Add(FordTruck);
vehicles.Add(toyotaVan);
vehicles.Add(ldvVan);

Console.WriteLine("Welcome to the Vehicle Management System. Enter your current speed");
int userSpd = Convert.ToInt32(Console.ReadLine());

foreach (Vehicle vehicle in vehicles)
{
    vehicle.PrintDetails();
    vehicle.Drive(userSpd);

}

////OUTPUT
//Ford.PrintDetails(); //OVERRIDEN THE DEFAULT
//FordTruck.PrintDetails();//DEFUALT
////Week 4 Prints
//toyotaVan.PrintDetails();//Ovveriden AND the bool is true
//ldvVan.PrintDetails();//Ovveriden AND the bool is false


//END OF PROGRAM
Console.ReadKey();  
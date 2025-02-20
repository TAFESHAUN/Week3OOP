using Week3OOP;
using System.Collections.Generic;

//LIST OF VEHICLES
List<Vehicle> vehicles = new List<Vehicle>();

//OBJECTS GO HERE
Car Ford = new Car("Mustang","GT",205);
Truck FordTruck = new Truck("F-150", "Raptor", 180);
//Ford.Make = "Mustang";
//Ford.Model = "GT";
//Ford.MaxSpeed = 205;

vehicles.Add(Ford);
vehicles.Add(FordTruck);


//OUTPUT
Ford.PrintDetails(); //OVERRIDEN THE DEFAULT
FordTruck.PrintDetails();//DEFUALT
//Console.WriteLine($"The " +
//    $"{Ford.Make} " +
//    $"{Ford.Model} has a top speed of " +
//    $"{Ford.MaxSpeed} kph.");
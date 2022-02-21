using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Done **** Separate Tab *** - Create a seperate class file called Car
            //Done **** Separate Tab *** - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done **** Separate Tab ***  - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            /// **** Separate Tab *** 

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var westLot = new CarLot();

            // Using Dot Notation
            var carOne = new Car();
            carOne.Make = "Toyota";
            carOne.Model = "4Runner";
            carOne.Year = 2020;
            carOne.EngineNoise = "vroom-vroom";
            carOne.HonkNoise = "beep-beep";
            carOne.IsDrivable = true;
            // adding this car to our carLot
            westLot.CarList.Add(carOne);

            // Object initializer cyntax
            var carTwo = new Car()
            {
                Make = "Subaru",
                Model = "Forester",
                Year = 2020,
                EngineNoise = "vah-room",
                HonkNoise = "bleep",
                IsDrivable = true
            };
            westLot.CarList.Add(carTwo);


            // Using a constructor
            var carThree = new Car(2013, "Honda", "Civic", "vrrrroom", "vruuuga", true);
            westLot.CarList.Add(carThree);

            //Calling methods
            Console.WriteLine($"This is the list of engine noises:");
            carOne.MakeEngineNoise(carOne.EngineNoise);
            carTwo.MakeEngineNoise(carTwo.EngineNoise);
            carThree.MakeEngineNoise(carThree.EngineNoise);
            Console.WriteLine();
            Console.WriteLine($"This is the list of honking noises:");
            carOne.MakeHonkNoise(carOne.HonkNoise);
            carTwo.MakeHonkNoise(carTwo.HonkNoise);
            carThree.MakeHonkNoise(carThree.HonkNoise);
            Console.WriteLine();

            Console.WriteLine($"Here is list of cars in the West Lot: ");
            foreach (var car in westLot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make}  Model: {car.Model}");
            }
    

            //*************BONUS*************//

            // DONE - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Done - Create a CarLot class
            //Done - It should have at least one property: a List of cars
            //Done - Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //Done - At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}

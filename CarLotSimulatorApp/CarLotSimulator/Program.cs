using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            var lot = new CarLot();

            Car myCar1 = new Car(1999, "Honda", "Accord", "Vroom", "Beep", true);

            Car myCar2 = new Car();
            myCar2.Year = 2001;
            myCar2.Make = "Toyota";
            myCar2.Model = "4Runner";
            myCar2.EngineNoise = "Brrrr";
            myCar2.HonkNoise = "Boop";
            myCar2.IsDrivable = true;

            Car myCar3 = new Car()
            { Year = 2004, Make = "Nissan", Model = "Altima", EngineNoise = "bloop", HonkNoise = "Bop", IsDrivable = false};

            lot.Cars.Add(myCar1);
            lot.Cars.Add(myCar2);
            lot.Cars.Add(myCar3);



            myCar1.MakeEngineNoise();
            myCar1.MakeHonkNoise();
            myCar2.MakeEngineNoise();
            myCar2.MakeHonkNoise();
            myCar3.MakeEngineNoise();
            myCar3.MakeHonkNoise();
            Console.WriteLine(myCar1.MyId);
            Console.WriteLine(myCar2.MyId);
            Console.WriteLine(myCar3.MyId);
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"{car.Year}, {car.Make}, {car.Model}, {car.EngineNoise}, {car.HonkNoise}, {car.IsDrivable}");
            }


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}

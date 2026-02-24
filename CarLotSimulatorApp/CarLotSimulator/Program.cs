using System;

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
            
            var JoesUsedCars = new CarLot();

            // Dot Notation
            var chevy = new Car();
            chevy.Year = 2024;
            chevy.Make = "Chevrolet";
            chevy.Model = "Tahoe";
            chevy.EngineNoise = "Clank, clank, clank";
            chevy.HonkNoise = "BEEP!";
            chevy.IsDrivable = true;

            chevy.MakeEngineNoise(chevy.EngineNoise);
            chevy.MakeHonkNoise(chevy.HonkNoise);
            JoesUsedCars.JoesCars.Add(chevy);
            
            // Object Initializer
            var ford = new Car()
            {
                Year = 2024,
                Make = "Ford",
                Model = "F-150",
                EngineNoise = "Vroooooooommmm",
                HonkNoise = "HONK!",
                IsDrivable = true
            };
            ford.MakeEngineNoise(ford.EngineNoise);
            ford.MakeHonkNoise(ford.HonkNoise);
            JoesUsedCars.JoesCars.Add(ford);
            
            
            // Custom Constructor
            var yoda = new Car(2024, "Toyota", "LandCrusier", "WOOOOOO", "BEEP BEEP!", true);
            
            yoda.MakeEngineNoise(yoda.EngineNoise);
            yoda.MakeHonkNoise(yoda.HonkNoise);
            JoesUsedCars.JoesCars.Add(yoda);

            JoesUsedCars.CarInfo();

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

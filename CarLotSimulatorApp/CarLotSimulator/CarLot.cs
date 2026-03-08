using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{//Added the static int numberOfCars per the instructions
    public static int numberOfCars; 
                                    
    public List<Car> JoesCars { get; set; } = new List<Car>();

    public void CarInfo()
    {
        foreach(var car in JoesCars)
        { 
            Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
        }
    }




}
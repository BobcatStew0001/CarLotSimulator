using System;
using System.Reflection.Metadata.Ecma335;

namespace CarLotSimulator;

public class Car
{
    public int Year;
    public string Make;
    public string Model;
    public string EngineNoise { get; set; } 
    public string HonkNoise { get; set; }
    public string IsDrivable { get; set; }

public void MakeEngineNoise()
{
    Console.WriteLine("Vroom Vroom Vroom Vroom Vroom");
}
public void MakeHonkNoise()
{
    Console.WriteLine("Beep, Beep, OOOOGGGAAAHHH, Beep, Beep");
}


public Car()
{
}

public Car(int year, string make, string model, string engineNoise, string isDrivable)
{
    Year = year;
    Make = make;
    Model = model;
    EngineNoise = engineNoise;
    IsDrivable = isDrivable;
}
}

using System;

namespace InterfaceExercise;

public class Sho : ISho
{
    public string Greet { get; set; } = "Welcome to the Interface Exercise";

    public void SelectionMenu()
    {
        Console.WriteLine("Please choose one of the following vehicles.\n");
        Console.WriteLine("1. Car");
        Console.WriteLine("2, Truck");
        Console.WriteLine("3. SUV");
    }

    public void VehicleMenu1()
    {
        Console.WriteLine("Nice choice! This is an excellent car!\n");
    }

    public void VehicleMenu2()
    {
        Console.WriteLine(
            "That's a good ol workhorse!...Emphasis on the old. Manual everything...even the steering.\n");
    }

    public void VehicleMenu3()
    {
        Console.WriteLine("*slaps roof* This bad boy can haul so many damn kids.\n");
    }
    // public string Menu { get; set; }


    public string SendGreet()
    {
        return Greet;
    }
}
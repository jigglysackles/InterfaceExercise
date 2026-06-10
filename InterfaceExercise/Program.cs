using System;

namespace InterfaceExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Instructions prt1

        //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

        //Create 2 Interfaces called IVehicle & ICompany

        //Create 3 classes called Car , Truck , & SUV

        //In your IVehicle:

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: public int NumberOfWheels { get; set; }
         */


        //In ICompany: 

        /* Create 2 members that are specific to each every company
         * regardless of vehicle type.
         * Example: public string Logo { get; set; }
         */

        //In each of your Car, Truck, and SUV classes

        /* Create 2 members that are specific to each class
         * Example for Car: public bool HasTrunk { get; set; }
         * Example for SUV: public int NumberOfSeats { get; set; }
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         */

        #endregion

        #region Instructions prt2

        //Now, create objects of your 3 classes and give their members values.
        //Creatively display and organize their values

        #endregion

        var wrx = new Car();
        wrx.BrandName = "Subaru";
        wrx.Color = "Blue";
        wrx.CountryOfOrigin = "Japan";
        wrx.LowRideHeight = true;
        wrx.ManualTransmission = true;
        wrx.NumberOfWheels = 4;
        wrx.SedanOrCoupe = "Coupe";
        wrx.TintLevelZeroToHundred = 70;

        var f100 = new Truck();
        f100.BrandName = "Ford";
        f100.Color = "Blue and White";
        f100.CountryOfOrigin = "USA";
        f100.ManualTransmission = true;
        f100.NumberOfWheels = 4;
        f100.TintLevelZeroToHundred = 0;
        f100.HasOpenBed = true;
        f100.ManualTransmission = true;

        var pilot = new SUV();
        pilot.BrandName = "Honda";
        pilot.Color = "Maroon";
        pilot.CountryOfOrigin = "Japan";
        pilot.NumberOfSeatRows = 3;
        pilot.HasLiftGate = true;
        pilot.ManualTransmission = false;
        pilot.NumberOfWheels = 4;
        pilot.TintLevelZeroToHundred = 30;

        var shoMenu = new Sho();
        var endLoop = false;

        Console.WriteLine(shoMenu.SendGreet());

        do
        {
            shoMenu.SelectionMenu();
            Console.WriteLine();
            var readResultSelectionMenu = Console.ReadKey();
            Console.Clear();
            switch (readResultSelectionMenu.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    shoMenu.VehicleMenu1();
                    foreach (var property in wrx.GetType().GetProperties())
                        Console.WriteLine($"{property.Name}: {property.GetValue(wrx)}");
                    endLoop = true;
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    shoMenu.VehicleMenu2();
                    foreach (var property in f100.GetType().GetProperties())
                        Console.WriteLine($"{property.Name}: {property.GetValue(f100)}");
                    endLoop = true;
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    shoMenu.VehicleMenu3();
                    foreach (var property in pilot.GetType().GetProperties())
                        Console.WriteLine($"{property.Name}: {property.GetValue(pilot)}");
                    endLoop = true;
                    break;

                default:
                    Console.WriteLine("That ain't right.");
                    endLoop = false;
                    break;
            }
        } while (!endLoop);
    }
}
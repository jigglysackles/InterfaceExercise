namespace InterfaceExercise;

public class Car :ICompany, IVehicle
{
    public string SedanOrCoupe { get; set; }
    public bool LowRideHeight { get; set; }
    public string BrandName { get; set; }
    public string CountryOfOrigin { get; set; }
    public string Color { get; set; }
    public int NumberOfWheels { get; set; }
    public bool ManualTransmission { get; set; }
    public int TintLevelZeroToHundred { get; set; }
}
namespace InterfaceExercise;

public class Truck : ICompany, IVehicle
{
    public bool HasOpenBed { get; set; }
    public bool HighTowCapacity { get; set; }
    public string BrandName { get; set; }
    public string CountryOfOrigin { get; set; }
    public string Color { get; set; }
    public int NumberOfWheels { get; set; }
    public bool ManualTransmission { get; set; }
    public int TintLevelZeroToHundred { get; set; }
}
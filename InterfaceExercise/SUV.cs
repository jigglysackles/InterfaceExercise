namespace InterfaceExercise;

public class SUV : ICompany, IVehicle
{
    public int NumberOfSeatRows { get; set; }
    public bool HasLiftGate { get; set; }
    public string BrandName { get; set; }
    public string CountryOfOrigin { get; set; }
    public string Color { get; set; }
    public int NumberOfWheels { get; set; }
    public bool ManualTransmission { get; set; }
    public int TintLevelZeroToHundred { get; set; }
}
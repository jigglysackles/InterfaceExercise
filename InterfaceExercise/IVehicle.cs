namespace InterfaceExercise;

public interface IVehicle
{
    public string Color { get; set; }
    public int NumberOfWheels { get; set; }
    public bool ManualTransmission { get; set; }
    public int TintLevelZeroToHundred { get; set; }  
}
namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public bool HasTruckBed { get; set; }
    public int TruckBedSpace { get; set; }
    
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool HasWheels { get; set; }
    public string Logo { get; set; }
    public bool BasedInAmerica { get; set; }
}
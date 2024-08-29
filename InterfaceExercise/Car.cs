namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public bool HasTrunk { get; set; }
    public int TrunkSpace { get; set; }

    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool HasWheels { get; set; }
    public string Logo { get; set; }
    public bool BasedInAmerica { get; set; }
}
namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public int RowSeating { get; set; }
    public int CargoHoldSpace { get; set; }

    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool HasWheels { get; set; }
    public string Logo { get; set; }
    public bool BasedInAmerica { get; set; }
}
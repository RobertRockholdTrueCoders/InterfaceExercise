namespace InterfaceExercise;
using System.Collections.Generic;

public interface IVehicle
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool HasWheels { get; set; }
}
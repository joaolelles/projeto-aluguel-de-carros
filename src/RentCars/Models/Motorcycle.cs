using RentCars.Types;

namespace RentCars.Models;

//7 - Faça a classe `Motorcycle` herdar de `Vehicle`
public class Motorcycle : Vehicle
{
    public int SeatHeight { get; set; }
    public BrakeType FrontBrake { get; set; }
    public BrakeType RearBrake { get; set; }
}
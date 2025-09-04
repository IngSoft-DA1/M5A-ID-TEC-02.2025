namespace Domain;

public class Truck : Vehicle
{
    public override string TurnOn()
    {
        return $"Encendiendo camioneta de color {Color} con {Doors} puertas";
    }
}
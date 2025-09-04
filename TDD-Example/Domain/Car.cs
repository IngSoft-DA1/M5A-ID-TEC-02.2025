namespace Domain;

public class Car : Vehicle
{
    public override string TurnOn()
    {
        return $"Encendiendo auto de color {Color} con {Doors} puertas";
    }
}
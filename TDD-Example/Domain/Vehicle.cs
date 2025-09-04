namespace Domain;

public abstract class Vehicle
{
    private int _doors;

    private string _color;

    public int Doors
    {
        get => _doors;
        set
        {
            if(value < 2 || value > 4)
                throw new ArgumentException("Doors amount must be between 2 and 4");
            _doors = value;
        }
    }

    public string Color
    {
        get => _color;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Color cannot be empty");
            _color = value;
        }
    }

    public abstract string TurnOn();

}
using Domain;

List<Vehicle> vehicles = [];

Vehicle car1 = new Car()
{
    Color = "Red",
    Doors = 4
};

Vehicle truck1 = new Truck()
{
    Color = "Blue",
    Doors = 2
};

vehicles.Add(car1);
vehicles.Add(truck1);

foreach (var vehicle in vehicles)
{
    var response = vehicle.TurnOn();
    Console.WriteLine(response);
}
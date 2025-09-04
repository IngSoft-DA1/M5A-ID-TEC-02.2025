namespace Domain.Tests;

[TestClass]
public class TruckTests
{
    private Vehicle _validVehicle;
    
    [TestInitialize]
    public void Setup()
    {
        _validVehicle = new Truck
        {
            Color = "Red",
            Doors = 4
        };
    }
    
    [TestMethod]
    public void NewVehicle_WhenValidParameters_ThenVehicleIsCreated()
    {
        Assert.IsNotNull(_validVehicle);
        Assert.AreEqual("Red", _validVehicle.Color);
        Assert.AreEqual(4, _validVehicle.Doors);
    }
    
    [TestMethod]
    public void NewVehicle_WhenInvalidDoorsAmount_ThenThrowsArgumentException()
    {
        Exception ex = Assert.ThrowsException<ArgumentException>(() => _validVehicle.Doors = -1);
        Assert.AreEqual("Doors amount must be between 2 and 4", ex.Message);
    }
    
    [TestMethod]
    public void NewVehicle_WhenEmptyColor_ThenThrowsArgumentException()
    {
        Exception ex = Assert.ThrowsException<ArgumentException>(() => _validVehicle.Color = "");
        Assert.AreEqual("Color cannot be empty", ex.Message);
    }
    
    [TestMethod]
    public void TurnOn_WhenCalled_ThenReturnsCorrectString()
    {
        // Arrange
        Vehicle truck = new Truck
        {
            Color = "Blue",
            Doors = 2
        };
        // Act
        string response = truck.TurnOn();
        // Assert
        Assert.AreEqual("Encendiendo camioneta de color Blue con 2 puertas", response);
    }
}
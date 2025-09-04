namespace Domain.Tests;

[TestClass]
public class CarTests
{
    private Vehicle _validVehicle;
    
    [TestInitialize]
    public void Setup()
    {
        _validVehicle = new Car
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
        Vehicle car = new Car
        {
            Color = "Green",
            Doors = 4
        };
        // Act
        string response = car.TurnOn();
        // Assert
        Assert.AreEqual("Encendiendo auto de color Green con 4 puertas", response);
    }
}
// See https://aka.ms/new-console-template for more information
using Domain;



Console.WriteLine("Ingrese datos del usuario");
Console.Write("Ingrese nombre: ");
string nombre = Console.ReadLine();
Console.Write("Ingrese fecha de nacimiento: ");
string date = Console.ReadLine();

if (DateTime.TryParse(date, out DateTime validDate))
{

    Persona persona = new Persona
    {
        Name = nombre,
        BirthDate = validDate,
    };
    
    Console.WriteLine("El usuario tiene nombre {0}", persona.Name);
    Console.WriteLine($"El usuario tiene edad {persona.GetAge()}");
    Console.WriteLine("El usuario nacio el dia {0}", persona.DayOfTheWeekBirth());
    
}

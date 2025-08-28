using System.Globalization;

namespace Domain;

public class Persona
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    public int GetAge()
    {
        return DateTime.Now.Year - BirthDate.Year;
    }

    public string DayOfTheWeekBirth()
    {
        return this.BirthDate.ToString("dddd", new CultureInfo("es-ES")); // Convertir a espanol
        // return this.BirthDate.DayOfWeek.ToString(); // Por defecto en ingles
    }
}
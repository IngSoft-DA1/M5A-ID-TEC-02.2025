# Test Unitarios siguiendo TDD

## Contexto
1. Crear proyecto dominio para las clases
2. Crear proyecto de test para las entidades
3. Se pide crear la clase vehiculo
    * Atributos:
        * doors (No puede ser menor que 2 ni mayor que 4)
        * color (No puede ser vacio)
    * Metodos:
        * TurnOn
4. Crear clases que heredan de vehiculo auto y camion, que implementan el metodo `TurnOn`
    * "Encendiendo `clase` con cantidad de puertas `doors` y color `color`.
5. Crear una lista de vehiculos y encenderlos 


## Estructura de la solucion
```
TDD-Example -> Solucion
├── Domain -> Proyecto class library
│   ├── Car.cs
│   ├── Truck.cs
│   └── Vehicle.cs
│
├── Domain.Tests -> Proyecto de test (MSTest)
│   ├── CarTests.cs
│   ├── TruckTests.cs
│
└── ConsoleApp -> Proyecto de consola
    ├── Program.cs
``` 



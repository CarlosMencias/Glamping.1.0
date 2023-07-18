
using Logica.Programa;
//Console.WriteLine("Ingrese su nombre: ");
//string? Reserv = Console.ReadLine();

try
{
    Console.WriteLine("Ingrese el nombre del reservante:");
    string? Nombre1 = Console.ReadLine();

    Console.WriteLine("Ingrese su apellido:");
    string? Apellido1 = Console.ReadLine();

    Console.WriteLine("Ingrese su correo:");
    string? Correo1 = Console.ReadLine();

    Console.WriteLine("Ingrese su número celular: ");
    int Celular1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la cantidad de huespedes: ");
    int Huespedes1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese cuantos dias va a reservar: ");
    int Dias1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el día de reserva: juesves, viernes, sabado o domingo:");
    string? Reserva1 = Console.ReadLine();

    Console.WriteLine("==============================================================");

    var Cliente1 = new Precios()
    {
        Nombre = Nombre1,
        Apellido = Apellido1,
        Correo = Correo1,
        Celular = Celular1,
        Huespedes = Huespedes1,      
        Precio = 4,




        Dias = Dias1,
        Reservar = Reserva1,

    };
    Console.WriteLine(Cliente1);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
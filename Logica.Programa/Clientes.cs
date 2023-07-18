namespace Logica.Programa
{
    public abstract class Clientes
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public string? Correo { get; set; }
        public int Celular { get; set; }
        public int Huespedes { get; set; }

        public string? _reservar { get; set; }

        public string? Reservar
        {
            get => _reservar;
            set => _reservar = ValidateReservar(value);
        }

        

        public override string ToString()
        {
            return $"Nombre..................:{Nombre,20}\n" +
                   $"Apellido................:{Apellido,20}\n" +
                   $"Correo..................:{Correo,20}\n" +
                   $"Celular.................:{Celular,20}\n" +
                   $"Huespedes...............:{Huespedes,20}\n" +
                   $"Reserva.................:{Reservar,20}\n";
        }

        private string? ValidateReservar(string? value)
        {
            if (value == "jueves" || value == "viernes" || value == "sabado" || value == "domingo")

            {
                return value;

            }
            throw new ArgumentException("Día no inválido. Los días permitidos son jueves, viernes, sabado y domingo.");
        }
        public abstract decimal GetValueToPay();

    }

    
}
using Logica.Programa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Programa
{
    public class Reserva
    {
        public string? _dia;

        public Reserva()
        {
            _dia = "Sabado";
        }

        public Reserva(string? dia)
        {
            _dia = ValidateDia(dia);
        }

        public string? Dia
        {
            get => _dia;
            set => _dia = ValidateDia(value);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Dia....................:{Dia,20:C2}\n\t";
        }

        private string? ValidateDia(string? value)
        {
            if (value == "jueves" || value == "viernes" || value == "sabado" || value == "domingo")

            {
                return value;

            }
            throw new ArgumentException("Día no inválido. Los días permitidos son jueves, viernes, sabado y domingo.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Programa
{
    public class Precios : Clientes
    {
        public decimal _precio;
        public int _dias;

        public Precios()
        {
            _precio = 5;
        }

        public decimal Precio 
        { 
            get => _precio; 
            set => _precio = (value); 
        }

        public int Dias
        {
            get => _dias;
            set => _dias = ValidateDias(value);
        }

        

        public override decimal GetValueToPay()
        {
            return (decimal)Huespedes * Precio * Dias;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Precio por persona......:{Precio,20:C2}\n" +
                   $"Total a pagar...........:{GetValueToPay(),20:C2}\n";
        }

        private int ValidateDias(int value)
        {
            if (value < 2)
            {
                throw new ArgumentException("Lo sentimos, minimo son 2 personas");
            }
            else if (value > 5)
            {
                throw new ArgumentException("Lo sentimos, solo un máximo de 5 personas");
            }
            return value;
        }
    }
}
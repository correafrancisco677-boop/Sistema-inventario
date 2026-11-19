using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public int Cantidad { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: RD{Precio:N2}");
            Console.WriteLine($"Cantidad: {Cantidad}");
        }

        public decimal CalcularValorTotal()
        {
            decimal precioDecimal = decimal.Parse(Precio);
            return precioDecimal * Cantidad;
        }

    }
}
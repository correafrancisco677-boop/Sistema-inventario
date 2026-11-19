using System;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==SISTEMA DE INEVTARIO==");
            Console.WriteLine("-----------------------");

            Producto producto1 = new Producto();
            producto1.Codigo = "P001";
            producto1.Nombre = "Tablet";
            producto1.Precio = "3500.00";
            producto1.Cantidad = 10;

            Producto producto2 = new Producto();
            producto2.Codigo = "P002";
            producto2.Nombre = "PC";
            producto2.Precio = "5000.00";
            producto2.Cantidad = 5;

            Producto producto3 = new Producto();
            producto3.Codigo = "P003";
            producto3.Nombre = "Smartphone";
            producto3.Precio = "2000.00";
            producto3.Cantidad = 15;

            Console.WriteLine("==INFORMACION DE PRODUCTOS==");

            producto1.MostrarInformacion();
            Console.WriteLine($"Valor total: RD{producto1.CalcularValorTotal():N2}");

            producto2.MostrarInformacion();
            Console.WriteLine($"Valor total: RD{producto2.CalcularValorTotal():N2}");

            producto3.MostrarInformacion();
            Console.WriteLine($"Valor total: RD{producto3.CalcularValorTotal():N2}");

        }
    }
}
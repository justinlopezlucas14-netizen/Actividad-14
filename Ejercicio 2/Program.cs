using System;
using System.Collections.Generic;

namespace RegistroInventario
{
    class Producto
    {
        public string Nombre;
        public double Precio;
        public int Cantidad;

        public Producto(string nombre, double precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public double CalcularValorTotal() => Precio * Cantidad;

        public string DeterminarEstadoStock()
        {
            if (Cantidad == 0) return "Sin existencia";
            if (Cantidad < 10) return "Stock bajo";
            return "Stock suficiente";
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Prod: {Nombre,-12} | Stock: {Cantidad,4} | Total: ${CalcularValorTotal(),8:F2} | Estado: {DeterminarEstadoStock()}");
        }
    }

    class Program
    {
        static void Main()
        {
            List<Producto> listaProd = new List<Producto>();
            Console.Write("¿Cuántos productos desea registrar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nProducto {i + 1}:");
                Console.Write("Nombre: "); string nom = Console.ReadLine();
                Console.Write("Precio: "); double pre = double.Parse(Console.ReadLine());
                Console.Write("Cantidad: "); int cant = int.Parse(Console.ReadLine());
                listaProd.Add(new Producto(nom, pre, cant));
            }

            Console.WriteLine("\nLISTA DE PRODUCTOS");
            double totalGeneral = 0;
            foreach (var p in listaProd)
            {
                p.MostrarInfo();
                totalGeneral += p.CalcularValorTotal();
            }

            var masCaro = listaProd.OrderByDescending(p => p.Precio).First();
            Console.WriteLine($"\nValor total inventario: ${totalGeneral:F2}");
            Console.WriteLine($"Producto con mayor precio: {masCaro.Nombre} (${masCaro.Precio:F2})");
        }
    }
}

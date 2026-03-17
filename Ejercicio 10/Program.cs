using System;
using System.Collections.Generic;

List<Pedido> pedidos = new List<Pedido>();
Console.Write("¿Cuántos pedidos desea registrar?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Pedido p = new Pedido();
    Console.WriteLine($"\nPedido {i + 1}");
    Console.Write("Cliente: "); p.Cliente = Console.ReadLine();
    Console.Write("Producto: "); p.Producto = Console.ReadLine();
    Console.Write("Cantidad: "); p.Cantidad = int.Parse(Console.ReadLine());
    Console.Write("Precio unitario: "); p.PrecioUnitario = double.Parse(Console.ReadLine());
    pedidos.Add(p);
}

double totalVentas = 0;
Console.WriteLine("\nPEDIDOS REGISTRADOS");
foreach (Pedido p in pedidos)
{
    p.MostrarDatos();
    totalVentas += p.CalcularTotalFinal();
}

Console.WriteLine($"\nTotal general de pedidos: Q{totalVentas:F2}");
class Pedido
{
    public string Cliente;
    public string Producto;
    public int Cantidad;
    public double PrecioUnitario;

    public double CalcularSubtotal() { return Cantidad * PrecioUnitario; }
    public double CalcularEnvio()
    {
        if (CalcularSubtotal() >= 300) return 0;
        else return 25;
    }
    public double CalcularTotalFinal() { return CalcularSubtotal() + CalcularEnvio(); }
    public void MostrarDatos()
    {
        Console.WriteLine($"Cliente: {Cliente} Producto: {Producto} Cantidad: {Cantidad} Subtotal: Q{CalcularSubtotal():F2} Envío: Q{CalcularEnvio():F2} Total final: Q{CalcularTotalFinal():F2}");
    }
}

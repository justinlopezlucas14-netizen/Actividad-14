using System;
using System.Collections.Generic;

List<Cuenta> cuentas = new List<Cuenta>();
Console.Write("¿Cuántas cuentas desea crear? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Cuenta c = new Cuenta();
    Console.WriteLine($"\nCuenta {i + 1}");

    Console.Write("Titular: ");
    c.Titular = Console.ReadLine();

    Console.Write("Saldo inicial: ");
    c.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Monto a depositar: ");
    double deposito = double.Parse(Console.ReadLine());
    c.Depositar(deposito);

    Console.Write("Monto a retirar: ");
    double retiro = double.Parse(Console.ReadLine());
    bool retiroExitoso = c.Retirar(retiro);

    if (!retiroExitoso)
    {
        Console.WriteLine("No se pudo realizar el retiro por saldo insuficiente.");
    }

    cuentas.Add(c);
}

Console.WriteLine("\nCUENTAS REGISTRADAS");
double saldoTotalGlobal = 0;
foreach (Cuenta c in cuentas)
{
    c.MostrarDatos();
    saldoTotalGlobal += c.Saldo;
}

Console.WriteLine($"\nSaldo final de todas las cuentas: Q{saldoTotalGlobal:F2}");

class Cuenta
{
    public string Titular;
    public double Saldo;

    public void Depositar(double monto)
    {
        Saldo += monto;
    }

    public bool Retirar(double monto)
    {
        if (monto <= Saldo)
        {
            Saldo -= monto;
            return true;
        }
        return false;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Titular: {Titular}  Saldo actual: Q{Saldo:F2}");
    }
}

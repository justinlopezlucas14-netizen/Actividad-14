List<Empleado> listaEmpleados = new List<Empleado>();

Console.Write("¿Cuántos empleados registrará? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nEmpleado {i + 1}:");
    Console.Write("Nombre: ");
    string nom = Console.ReadLine();
    Console.Write("Puesto: ");
    string pue = Console.ReadLine();
    Console.Write("Salario Mensual: ");
    double sal = double.Parse(Console.ReadLine());

    listaEmpleados.Add(new Empleado(nom, pue, sal));
}

Console.WriteLine("\n---Reporte de Empleados ---");
foreach (var emp in listaEmpleados)
{
    emp.MostrarInfo();
}

public class Empleado
{
    public string Nombre;
    public string Puesto;
    public double SalarioMensual;

    public Empleado(string n, string p, double s)
    {
        Nombre = n; Puesto = p; SalarioMensual = s;
    }

    public double CalcularAnual() => SalarioMensual * 12;
    public double CalcularBono() => SalarioMensual > 5000 ? SalarioMensual * 0.10 : SalarioMensual * 0.15;
    public string Clasificar()

    {
        if (SalarioMensual <= 3000) return "Básico";
        if (SalarioMensual <= 7000) return "Medio";
        return "Alto";
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"{Nombre} - {Puesto} | Anual: Q{CalcularAnual():N2} | Bono: Q{CalcularBono():N2} | Rango: {Clasificar()}");
    }
}
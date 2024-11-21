// See https://aka.ms/new-console-template for more information
using Ejercicio04;
using System.Numerics;
string regresar;
Productos p = new Productos();

do
{
    Console.WriteLine("****************************************\n");
    Console.WriteLine("1.       Registrar");
    Console.WriteLine("2.       Mostrar");
    Console.WriteLine("3.       Modificar");
    Console.WriteLine("\n****************************************");
    Console.Write("\nIngrese una opción: ");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: p.insertar(); break;
        case 2: p.mostrar(); break;
        case 3: break;
    }
    Console.Write("\nRegresar al menú? [si]: ");
    regresar = Console.ReadLine();
    Console.Clear();
} while (regresar == "si");

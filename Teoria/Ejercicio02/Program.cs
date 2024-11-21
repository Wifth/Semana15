// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

int fil = 4;
int col = 3;
int[][] mat = new int[fil][];
int i = 0, j = 0;

//Crea columnas*
for (int f = 0; f < mat.Length; f++)
{
    mat[f] = new int[col];
}

//Ingresa valores del Random*
Console.Write("Ingrese el valor mínimo: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ingrese el valor máximo: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine();

//Ingrreso números*
for (int f = 0; f < mat.Length; f++)
{
    for (int c = 0; c < mat[f].Length; c++)
    {
        Random rnd = new Random();
        mat[f][c] = rnd.Next(a,b + 1);
    }
}

//Salida*
for (int f = 0; f < mat.Length; f++)
{
    for (int c = 0; c < mat[0].Length; c++)
    {
        Console.Write($"{mat[f][c]}    ");
    }
    Console.WriteLine();
}

//Sumatoria de filas y colummnas*
for (int f = 0; f < mat.Length; f++)
{
    for (int c = 0; c < mat[0].Length; c++)
    {
        i += mat[f][c];
    }
    Console.Write($"\nSuma en fila {f+1}:    " + i);
}
Console.WriteLine();
for (int c = 0; c < mat[0].Length; c++)
{
    for (int f = 0; f < mat.Length; f++)
    {
        j += mat[f][c];
    }
    Console.Write($"\nSuma en columna {c+1}: " + j);
}
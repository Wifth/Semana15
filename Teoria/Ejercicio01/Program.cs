﻿// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");
int fil = 4;
int col = 3;
int[][] mat = new int[fil][];

//Crea columnas*
for (int f = 0; f < mat.Length; f++)
{
    mat[f] = new int[col];
}

//Ingrreso números*
for (int f = 0; f < mat.Length; f++)
{
    for (int c = 0; c < mat[f].Length; c++)
    {
        Console.Write($"En fila {f} Ingrese número {c}: ");
        mat[f][c] = Convert.ToInt32(Console.ReadLine());
    }
}

//Salida*
for (int f = 0; f < mat.Length; f++)
{
    for (int c = 0; c < mat[0].Length; c++)
    {
        Console.Write($"{mat[f][c]}, ");
    }
    Console.WriteLine();
}
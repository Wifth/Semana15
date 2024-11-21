// See https://aka.ms/new-console-template for more information
int fil = 4;
int col = 3;
int[][] mat = new int[fil][];

//Crea columnas*
for (int f = 0; f < mat.Length; f++)
{
    mat[f] = new int[col];
}

Console.Write("Ingrese el valor mínimo: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor máximo");
int b = int.Parse(Console.ReadLine());

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
        Console.Write($"{mat[f][c]}, ");
    }
    Console.WriteLine();
}
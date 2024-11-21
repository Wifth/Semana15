// See https://aka.ms/new-console-template for more information

Console.Write("Ingrese # filas: ");
int f = int.Parse(Console.ReadLine());
Console.Write("Ingrese # columnas: ");
int c = int.Parse(Console.ReadLine());

int[,] matriz = new int[f, c];
Random rnd = new Random();

Console.WriteLine("\n****************************************");
Console.WriteLine("\n   MATRIZ GENERADA ALEATORIAMENTE: \n");
Console.WriteLine("****************************************");

for (int i = 0; i < f; i++)
{
    for (int j = 0; j < c; j++)
    {
        matriz[i, j] = rnd.Next(30, 51);
        Console.Write($"{matriz[i, j]}\t");
    }
    Console.WriteLine();
}
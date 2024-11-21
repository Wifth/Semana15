// See https://aka.ms/new-console-template for more information

Console.Write("Ingrese # matriz: ");
int num = int.Parse(Console.ReadLine());

int[,] matriz = new int[num,num];
int[,] transpuesta = new int[num, num];
Random rnd = new Random();

Console.WriteLine("\n****************************************");
Console.WriteLine("\n   MATRIZ GENERADA ALEATORIAMENTE: \n");
Console.WriteLine("****************************************");
for (int i= 0;  i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        matriz[i,j] = rnd.Next(40,51);
        Console.Write($"{matriz[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n****************************************");
Console.WriteLine("\n           MATRIZ TRANSPUESTA: \n");
Console.WriteLine("****************************************");
for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        transpuesta[i,j] = matriz[i,j];
    }
}
for (int j = 0; j < num; j++)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{matriz[i, j]}\t");
    }
    Console.WriteLine();
}
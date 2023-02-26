// Задача 93: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int[,] a = new int[4, 4];
int[,] b = new int[4, 4];
int[,] c = new int[4, 4];
PrintAArray(a);
PrintBArray(b);
PrintMultiArray(c);




void PrintAArray(int[,] a)
{
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(20);
            System.Console.Write($"{a[i, j],4}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void PrintBArray(int[,] b)
{
    Random random = new Random();
    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            b[i, j] = random.Next(20);
            System.Console.Write($"{b[i, j],4}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("Произведение двух массивов:");
}
void PrintMultiArray(int[,] c)
{

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            c[i, j] = a[i, j] * b[i, j];
            Console.Write($"{c[i, j],4}");
        }
        Console.WriteLine();
    }
}

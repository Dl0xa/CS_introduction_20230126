// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

double[,] a = new double[10, 10];
{
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(100);
            Console.Write($"{a[i, j],6}");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (i != 0 && j != 0 && i % 2 == 0 && j % 2 == 0)
            {
                a[i, j] = Math.Pow(a[i, j], 2);
                Console.Write($"{a[i, j],6}");
            }
            else System.Console.Write($"{a[i, j],6}");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
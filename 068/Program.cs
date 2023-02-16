// 68. Написать программу, которая обменивает элементы первой строки и последней строки

int[,] a = new int[4, 4];
{
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(100);
            Console.Write($"{a[i, j],4}");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}
{
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (i == 0 || i==(a.GetLength(0)-1))
            {
                a[i, j] = random.Next(100);
                Console.Write($"{a[i, j],4}");
            }
            else System.Console.Write($"{a[i, j],4}");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}
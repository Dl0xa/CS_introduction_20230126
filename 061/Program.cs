// 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами

System.Console.Write("Введите число строк для двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число колонок для двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
{
    double[,] a = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.NextDouble();
            Console.Write($"{a[i, j], 6:F2}");
        }
        Console.WriteLine();
    }
}
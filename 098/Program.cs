// 98. Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.

System.Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] a = new int[n, n];
for (int i = 0; i < a.GetLength(0); i++)
{
    a[i, 0] = 1;
    a[i, i] = 1;
}
for (int i = 2; i < a.GetLength(0); i++)
{
    for (int j = 1; j <= i; j++)
    {
        a[i, j] = a[i - 1, j - 1] + a[i - 1, j];
    }
}

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(0); j++)
    {
        if (a[i, j] != 0)
            Console.Write($"{a[i, j],5}");
    }
    Console.WriteLine();
}
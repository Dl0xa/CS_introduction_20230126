// 52. Написать программу преобразования десятичного числа в двоичное

System.Console.Write("Введите число для преобразования: ");
int N1 = Convert.ToInt32(Console.ReadLine());
for (N1 = 0; N1 < 10; N1++)
{
    int N = N1;
    int N2 = 0;
    int k = 0;
    while (N != 0)

    {
        N2 = N2 + N % 2 * (int)Math.Pow(10, k);
        N = N / 2;
        k++;
    }
    System.Console.WriteLine($"Число {N1} в двоичной системе равно: {N2}");
}
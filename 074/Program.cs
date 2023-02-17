// 74. Найти сумму цифр числа

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum(int N)
{
    if (N < 0) return Sum(N * (-1));
    if (N > 0 && N < 10) return N;
    else return Sum(N % 10) + Sum(N / 10);
}
System.Console.WriteLine(Sum(N));

// 36. Написать программу вычисления произведения чисел от 1 до N

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
long multi = 1;

for (int i = 1; i <= N; i++)
{
    multi = multi * i;
}
System.Console.WriteLine(multi);
// 7. Выяснить является ли число чётным.

int N;
System.Console.WriteLine("введите число ");
N = Convert.ToInt32(Console.ReadLine());
bool odd = N % 2 == 0;
if (odd)
{
    System.Console.WriteLine($"Число {N} четное");
}
else
{
    System.Console.WriteLine($"Число {N} не четное");
}

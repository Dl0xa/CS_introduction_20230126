// 8. Вывести на экран числа от -N до N.

int N = 1;
int i = -N;
System.Console.WriteLine("введите отрицательное число ");
i = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите положительное число ");
N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ваши числа ");

while (i <= N)
{
    System.Console.WriteLine(i);
    i = i + 1;
}
// 31. Вывести на экран кубы чисел от 1 до N

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i < N)
    {
    System.Console.WriteLine(Math.Pow(i, 3));
    i++;
    }

if (i>N)
    System.Console.WriteLine("Неверное число!");
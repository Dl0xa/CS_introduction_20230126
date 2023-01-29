// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел.

int max;
int a;
int b;
int c;

System.Console.WriteLine("введите a");
a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите b");
b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите c");
c = Convert.ToInt32(Console.ReadLine());

max = a;
if (b > a)
    max = b;
if (c > b)
    max = c;
System.Console.WriteLine($"Максимальное число={max}");
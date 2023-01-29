// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.
int max;
int a;
int b;

System.Console.WriteLine("введите a");
a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите b");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    max = a;
else
    max = b;
System.Console.WriteLine($"Максимальное число={max}");
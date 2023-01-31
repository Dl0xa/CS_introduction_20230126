// 22. По двум заданным числам проверять является ли одно квадратом другого.

System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a==b*b)
    {
        int a1=b*b;
        System.Console.WriteLine($"a является квадратом b = {a1}");
    }
    else 
        {
            System.Console.WriteLine("a не является квадратом b");
        }
if (b==a*a)
{
        int b1=a*a;
        System.Console.WriteLine($"b является квадратом a = {b1}");
    }
    else 
        {
            System.Console.WriteLine("b не является квадратом a");
        }
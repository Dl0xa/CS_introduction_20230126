// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

System.Console.Write("Введите число, для которого необходима последовательность Фибоначчи: ");
int n = Convert.ToInt32(Console.ReadLine());
int F(int n)
{
    if (n == 1 || n == 2) return 1;
    else return F(n - 1) + F(n - 2);
}
Console.WriteLine("f(0) = 0");
{
    for (int i = 1; i < n; i++)
    {
        Console.WriteLine($"f({i}) = {F(i)}");
    }
}

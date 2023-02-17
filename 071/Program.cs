// 71. Показать натуральные числа от N до 1, N задано

System.Console.Write("Введите N, где N <=0: ");
int N = Convert.ToInt32(Console.ReadLine());
Loop(N, 1);
void Loop(int N, int i)
{
    System.Console.Write($"{N,5}");
    if (N < i) Loop(N + 1, i);
}

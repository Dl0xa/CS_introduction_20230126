// 35. Подсчитать сумму цифр в числе. Сделать подпрограмму.

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int DigitSum(int sum)
{
    while (N != 0)
    {
        int d = N % 10;
        sum += d;
        N /= 10;
    }
    return sum;
}

System.Console.WriteLine(DigitSum(sum));
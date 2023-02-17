// Без циклов написать программу которая выведет числа от 1 до N. goto тоже запрещен!

int N = 20;
int i = 0;
//System.Console.WriteLine(i++);//постинкримент
// System.Console.WriteLine(++i);
// System.Console.WriteLine(i);

// while (i < N)
// {
//     //i++; //инкремент
//     System.Console.Write($"{++i,4}");
// }

//ЭТО ЗАПРЕЩЕНО!!!  
// metka:
//     System.Console.Write($"{++i,4}");
// if (i<N) goto metka;// оператор безусловного перехода

//рекурсивный метод
void Loop(int i, int N)
{
    System.Console.Write($"{i,4}");
    if (i < N) Loop(i + 1, N);// рекурсия
}
Loop(1,15);

// // Вывести факториал
// int F(int N)
// {
//     if (N > 0) return F(N - 1) * N;
//     else return 1;
// }
// System.Console.WriteLine(F(13));

// // Вывести числа Фибоначчи
// int Fib(int N)
// {
//     if (N == 0) return 0;
//         else
//             if (N == 1) return 1;
//                 else
//                     return Fib(N - 1) + Fib(N - 2);
// }
// for (i=0;i<10;i++)
// System.Console.WriteLine(Fib(i));

// //Возведение в степень
// double Power(int a, int b)
// {
//     if (b == 0) return 1;
//     else
//             if (b > 0)
//         return Power(a, b - 1) * a;
//     else
//         return Power(a, b + 1) * 1 / a;
// }
// for (i = 0; i < 10; i++)
//     System.Console.WriteLine(Power(2, i));

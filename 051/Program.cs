﻿// 51. С клавиатуры вводится число N. Затем вводятся N чисел. 
// Определить сколько чисел больше 0 введено с клавиатуры

namespace GeekBrains
{
    namespace Introduction
    {

        class Task051
        {
            static void Main()
            {
                System.Console.Write("Сколько чисел будет учавствовать в выборке: ");
                int N = Convert.ToInt32(Console.ReadLine());
                int k = 0;
                for (int i = 0; i < N; i++)
                    {
                        System.Console.Write("Введите число: ");
                        int n = int.Parse(Console.ReadLine());
                        if (n > 0) k++;
                    }
                System.Console.WriteLine($"Введено чисел больше нуля: {k}" );
            }
        }
    }
}
﻿// С клавиатуры вводим два числа. Найти и вывести их сумму
//string s;

int a, b, sum;
System.Console.WriteLine("Введите a");
a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите b");
b = Convert.ToInt32(Console.ReadLine());
sum = a + b;
//1 Конкатенация (склеивание) строк 
System.Console.WriteLine(a + "+" + b + "=" + sum);
//2 Форматированный вывод
System.Console.WriteLine("{0:F2}+{1:E5}={2:G4}", a, b, sum);
//3 Интерполяция строк
System.Console.WriteLine("{a}+{b}={sum}", a, b, sum);
// 6. Написать программу вычисления значения функции y = sin(a). (Класс Math).

double a;
System.Console.Write("Введите число для расчета функции Sin(a): ");
a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Sin(a) = ");
Console.Write(Math.Sin(a));

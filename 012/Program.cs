// 12. С клавиатуры вводится целое число из диапазона [10, 99].Показать наибольшую цифру числа.

int n = 0;
System.Console.Write("Введите число в диапазоне от 10 до 99: ");
n = Convert.ToInt32(Console.ReadLine());
string a = n.ToString();

if (a[0]>a[1])
System.Console.WriteLine(a[0]);

if (a[0]<a[1])
System.Console.WriteLine(a[1]);


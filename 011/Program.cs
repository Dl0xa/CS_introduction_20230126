// 11. Дано число больше 9. Вывести на экран вторую цифру числа с конца

int n = 0;
int d1 = 0; //d0,d2
System.Console.Write("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());

d1 = n / 10 % 10; //d0 = n%10; d2=n/100;
System.Console.WriteLine($"{d1}");  //System.Console.WriteLine($"{d0} {d1} {d2}");
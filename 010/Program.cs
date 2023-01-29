// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры.

int n = 0;
int end = 0;
System.Console.Write("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());

end = n % 10;
System.Console.WriteLine($"{end}");

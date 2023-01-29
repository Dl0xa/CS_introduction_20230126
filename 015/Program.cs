// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string a = n.ToString();

if (n >= 100)
{
    Console.WriteLine(a[2]);
}
else
    System.Console.WriteLine("NO");
// 26. Программа проверяет пятизначное число на палиндром. Например: 12321


System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string a = n.ToString();

if (a[0]==a[4] && a[1]==a[3])
{
    Console.WriteLine("Число явлется палиндромом");
}
else
    System.Console.WriteLine("Число не является палиндромом");
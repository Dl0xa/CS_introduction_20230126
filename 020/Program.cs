// 20. Дано число. Проверить кратно ли оно 7 и 23

System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int div7=N/7;
int div23=N/23;

if(N%7==0 && N%23==0)
    {
    System.Console.WriteLine($"Число кратно 7 = {div7}");
    System.Console.WriteLine($"Число кратно 23 = {div23}");
    }
if(N%7!=0 && N%23==0)
    {
    System.Console.WriteLine($"Число не кратно 7 = {div7}");
    System.Console.WriteLine($"Число кратно 23 = {div23}");
    }
if(N%7==0 && N%23!=0)
    {
    System.Console.WriteLine($"Число кратно 7 = {div7}");
    System.Console.WriteLine($"Число не кратно 23 = {div23}");
    }
// 50. Выяснить являются ли три числа сторонами треугольника

System.Console.Write("Введите сторону треугольника a: ");
int a= Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите сторону треугольника b: ");
int b= Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите сторону треугольника c: ");
int c= Convert.ToInt32(Console.ReadLine());
if(a+b>c && a+c>b && b+c>a) System.Console.WriteLine("Являются"); 
else System.Console.WriteLine("Не являются");
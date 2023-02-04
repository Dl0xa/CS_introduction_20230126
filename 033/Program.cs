// 33. Возведите число А в натуральную степень B используя цикл

System.Console.Write("Введите число A: ");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень B: ");
int B = Convert.ToInt32(Console.ReadLine());
 
if (B>0)
{
double a = Math.Pow(A, B);
System.Console.WriteLine($"{A} в степени {B} = {a}");
}
else 
System.Console.WriteLine("Степень не является натуральной!");

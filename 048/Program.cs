// 48. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
// Создайте массив, который является произведением пар чисел в одномерном массиве a. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

System.Console.Write($"Задайте длину массива a: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < N; i++)
    a[i] = random.Next(1, 11);
for (int i = 0; i < N; i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();
int[] a1 = new int[N/2];
for (int i = 0; i < N/2; i++)
{
    a1[i] = a[i] * a[N-1-i];
    System.Console.Write($"{a1[i]} ");
}
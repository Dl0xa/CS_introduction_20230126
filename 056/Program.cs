// 56. Написать программу копирования массива

int[] a = { 1, 4, 8, 56, 3, 43, 23, 64, 53 };
int[] copy = new int[a.Length];
Array.Copy(a, copy, a.Length);
System.Console.WriteLine(string.Join(",", copy));
// 62. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
//Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив

System.Console.Write("Введите число строк для двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число колонок для двумерного массива: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,] a = new int[n,k];
int[,] b = new int[n,k];

PrintOrginArray(a);
PrintModifiedArray(b);

void PrintOrginArray (int [,] a)
{
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(100);
            Console.Write($"{a[i, j],4}");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintModifiedArray (int [,] b)
{
        for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Array.Copy(a,b, a.Length);
            a[i, j] = -b[i,j];
            Console.Write($"{a[i, j],4}");
        }
        Console.WriteLine();
    }
}


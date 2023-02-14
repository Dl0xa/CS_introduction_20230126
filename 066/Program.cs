// 66.Написать подпрограмму, которая в квадратной матрице чисел находит сумму элементов главной диагонали

int[,] Random2DArray(int N, int M, int min, int max)
{
    int[,] a = new int[N, M];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}

void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],5}");
        System.Console.WriteLine();
    }
}

int SumMainDiagonal(int[,] a)
{
    int s = 0;
    // for (int i = 0; i < a.GetLength(0); i++)
    //     for (int j = 0; j < a.GetLength(1); j++)
    //         if (i == j)
    //             s = s + a[i, j];
    for (int i = 0; i < a.GetLength(0); i++)
        s = s + a[i, i];
    return s;

}

bool FindElementIn2DArray(int[,] a, int find, out int row, out int column)
{
    row = -1;
    column = -1;
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            if (a[i, j] == find)
            {
                row = i;
                column = j;
                return true;
            }
    return false;
}

int[,] a = Random2DArray(4, 4, 0, 10);
Print2DArray(a);
int r, c;
if (FindElementIn2DArray(a, 10, out r, out c))
    System.Console.WriteLine($"row={r} column={c}");
else
    System.Console.WriteLine("Element not found");
System.Console.WriteLine(SumMainDiagonal(a));
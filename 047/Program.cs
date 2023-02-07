// 47. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] arr=new int[10];
Random random = new Random();
for (int i=0;i<arr.Length;i++)
    arr[i]=random.Next(0,5);

for (int i=0;i<arr.Length;i++)
    System.Console.Write($"{arr[i]} ");
System.Console.WriteLine();

int s=0;
for(int i=1; i<arr.Length; i=i+2)
s=s+arr[i];
System.Console.WriteLine(s);
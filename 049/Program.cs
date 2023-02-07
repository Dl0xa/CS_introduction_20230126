// 49. В Указанном массиве чисел найдите разницу между максимальным и минимальным элементом

int[] arr=new int[10];
Random random = new Random();
for (int i=0;i<arr.Length;i++)
    arr[i]=random.Next(0,5);

for (int i=0;i<arr.Length;i++)
    System.Console.Write($"{arr[i]} ");
System.Console.WriteLine();

int max=arr[0];
for(int i=1; i<arr.Length; i++)
    if(arr[1]>max)
        max=arr[1];

// for(int i=1; i<arr.Length; i++)
// max=int.Max(arr[i], max);

System.Console.WriteLine(max);

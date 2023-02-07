// 42. Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] arr=new int[5];
Random random = new Random();
for (int i=0;i<arr.Length;i++)
    arr[i]=random.Next(-9,10);

for (int i=0;i<arr.Length;i++)
    System.Console.WriteLine($"{arr[i]}");
System.Console.WriteLine();
int sp=0;
for (int i=0;i<arr.Length;i++)
    if(arr[i]>0)
    sp=sp+arr[i];
int sn=0;
for (int i=0;i<arr.Length;i++)
    if(arr[i]<0)
    sp=sn+arr[i];

System.Console.WriteLine($"Sum of positive number: {sp}");
System.Console.WriteLine($"Sum of negative number: {sn}");
// 46. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] arr = new int[123];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
    arr[i] = random.Next(0,500);
for (int i = 0; i < arr.Length; i++)
    System.Console.WriteLine($"{arr[i]} ");
int count=0;
for (int i = 0; i < arr.Length; i++)
    if(arr[i]>=10 && arr[i]<=99) count++;
    else count=count+0;
System.Console.WriteLine($"Количество попавших в массив чисел из отрезка [10, 99]: {count}");

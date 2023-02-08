// 45. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

System.Console.Write($"Задайте длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
    arr[i] = random.Next(100, 1000);
for (int i = 0; i < arr.Length; i++)
    System.Console.WriteLine($"{arr[i]} ");
    
int countpn=0;
for (int i = 0; i < arr.Length; i++)
    if (arr[i]%2==0)
        countpn++;
int countnn=0;
for (int i = 0; i < arr.Length; i++)
    if(arr[i]%2!=0)
       countnn++;

System.Console.WriteLine($"Quantity of positive number: {countpn}");
System.Console.WriteLine($"Quantity of negative number: {countnn}");

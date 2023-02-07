// 44. Определить, присутствует ли в заданном массиве, некоторое число
// Линейный поиск

int[] arr=new int[10];
Random random = new Random();
for (int i=0;i<arr.Length;i++)
    arr[i]=random.Next(-9,10);

for (int i=0;i<arr.Length;i++)
    System.Console.WriteLine($"{arr[i]}");
System.Console.WriteLine();

// Линейный поиск

int find=5;
int j = 0;
while (j<arr.Length && arr[j]!=find) j++;

if (j==arr.Length)
System.Console.WriteLine("NO");

else 
System.Console.WriteLine($"Element {find} found at index {j}");
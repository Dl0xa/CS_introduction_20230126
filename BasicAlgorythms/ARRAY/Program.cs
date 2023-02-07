// Массивы
// Инициализация переменных
double[] temps = new double[7];
//ввод данных
for (int i = 0; i < temps.Length; i++)
    temps[i] = Convert.ToInt32(Console.ReadLine());

// double [] temps=new double[30];
// for (int i =0; i<temps.Length;i++)
//     temps[i]=Convert.ToInt32(Console.ReadLine());
// Решение задачи
// Находим сумму массива
double s = 0;
for (int i = 0; i < temps.Length; i++)
    s = s + temps[i];
// вывод результата
System.Console.WriteLine(s / temps.Length);
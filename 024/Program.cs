// 24. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

System.Console.Write("Введите X ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 && y == 0) System.Console.WriteLine("Число 0 не подходит условию задачи");
if (x != 0 && y == 0) System.Console.WriteLine("Число 0 не подходит условию задачи");
if (x == 0 && y != 0) System.Console.WriteLine("Число 0 не подходит условию задачи");
if (x > 0 && y > 0) System.Console.WriteLine("Координаты находятся в четверти № 1");
if (x < 0 && y > 0) System.Console.WriteLine("Координаты находятся в четверти № 2");
if (x < 0 && y < 0) System.Console.WriteLine("Координаты находятся в четверти № 3");
if (x > 0 && y < 0) System.Console.WriteLine("Координаты находятся в четверти № 4");

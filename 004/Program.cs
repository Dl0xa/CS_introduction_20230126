// 4. По заданному с клавиатуры номеру дня недели вывести его название.

int a = 0;
Console.Write("Введите номер дня недели: ");
a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
    System.Console.WriteLine("Выбранный день - Monday");

if (a == 2)
    System.Console.WriteLine("Выбранный день - Thursday");

if (a == 3)
    System.Console.WriteLine("Выбранный день - Wednesday");

if (a == 4)
    System.Console.WriteLine("Выбранный день - Thursday");

if (a == 5)
    System.Console.WriteLine("Выбранный день - Friday");

if (a == 6)
    System.Console.WriteLine("Выбранный день - Saturday");

if (a == 7)
    System.Console.WriteLine("Выбранный день - Sunday");

if (a >= 8)
    System.Console.WriteLine("Неверное число, дней недели 7), вводите от 1 до 7");
    
if (a <= 0)
    System.Console.WriteLine("Неверное число, дней недели 7), вводите от 1 до 7");
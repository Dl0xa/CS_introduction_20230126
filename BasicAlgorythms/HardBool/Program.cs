﻿// По месяцу определить время года. Использование ИЛИ
// int month = 8;
// if (month == 1 || month == 2 || month == 12) System.Console.WriteLine("Winter");
// if (month == 3 || month == 4 || month == 5) System.Console.WriteLine("Spring");
// if (month == 6 || month == 7 || month == 8) System.Console.WriteLine("Summer");
// if (month == 9 || month == 10 || month == 11) System.Console.WriteLine("Autumn");

// Вводится возраст человека и нужно определить подходит ли он для работы (от 25 до 45) лет.

int age = 40;
// if(age>=25)
//     if(age<=45)
//         System.Console.WriteLine("Подходит");
//     else
//         System.Console.WriteLine("Не подходит");
// else
//     System.Console.WriteLine("Не подходит");

if (age>=25 && age <=45) //И и ИЛИ && - ленивый и
    System.Console.WriteLine("Подходит");
else
    System.Console.WriteLine("Не подходит");

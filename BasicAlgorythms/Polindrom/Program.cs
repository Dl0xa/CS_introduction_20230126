﻿// Полиндром

﻿string s="ПОТОП";
char[] s1=s.Reverse().ToArray();
string s2=new String(s1);
System.Console.WriteLine(s2);
if (s==s2) System.Console.WriteLine("Полиндорм"); else System.Console.WriteLine("Не полиндром");
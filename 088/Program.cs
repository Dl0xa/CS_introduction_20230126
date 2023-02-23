// 88. Заменить все вхождения подстроки w в строке st на строку v. 
// Вывести на экран первоначальную строку и конечную строку

string st = "One example of this was reported in the "
          + "VirtueMart plugin in Joomla, where anyone "
          + "could send arbitrary text to any recipient as spam, "
          + "wakeup!";
System.Console.WriteLine(st);
System.Console.WriteLine();
string s1 = "w";
string s2 = "v";
st = st.Replace(s1, s2);
System.Console.WriteLine(st);
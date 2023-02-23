// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

System.Console.Write("Введите произвольный символы: ");
string s = Console.ReadLine();
int k = 0;
for (int i = 0; i < s.Length; i++)
    if (s[i] == 'a' || s[i] == 'а') k++;
    System.Console.WriteLine($"Символ 'a' встречается: {k} раз");

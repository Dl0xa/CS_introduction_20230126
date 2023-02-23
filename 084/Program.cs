// 84. Определить являются ли введенные с клавиатуры символы правильной записью целого числа.
// Вычислить сумму цифр введенного числа

System.Console.Write("Введите символы: ");
string s = Console.ReadLine();
int sum = 0;
for (int i = 0; i < s.Length; i++)
{
    if (char.IsDigit(s[i])) sum += s[i] - 48;
    else
    {
        if (i == 0 && s[i] == '-') continue;
        else
        {
            Console.WriteLine("Не является верной записью целого числа");
            return;
        }
    }
}
Console.WriteLine("Сумма цифр числа: {0}", sum);
// Подсчитать кол-во цифр и сумму цифр

int N = 1234;
int counter = 0; // счетчик
int sum = 0;// сумматор

while (N != 0)
{
    counter++; //counter = counter + 1
    int d = N % 10;
    sum += d; //sum = sum + d;
    N /= 10; //N = N / 10;
}
System.Console.WriteLine(counter);
System.Console.WriteLine(sum);
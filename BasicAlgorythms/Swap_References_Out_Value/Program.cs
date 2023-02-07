// 

// void Swap(int x, int y)// передача по значению(value)
// {
//     int t=x;
//     x=y;
//     y=t;
// }



void Calculator(int a, int b, out int sum, out int sub)
{
sum=a+b;
sub=a-b;
}
int a = 4;
int b = 5;
int s=0,sb=0;
Calculator(a,b,out s,out sb);

// void Swap(out int x, out int y)// передача по ссылке(outerences)
// {
//     int t=x;
//     x=y;
//     y=t;
// }
// int a = 4;
// int b = 5;

// System.Console.WriteLine($"a={a} b={b}");
// // Классический(стандартный) обмен
// Swap(out a,out b);
// System.Console.WriteLine($"a={a} b={b}");

// int t;
// t=a;
// a=b;
// b=t;


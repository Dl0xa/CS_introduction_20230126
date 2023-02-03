// Алгоритм Эвклида

int a=270;
int b=10800;

while(a!=b)
{
    if(a>b)
         a-=b; //a=a-b
    else
         b-=a; //b=b-a
}

System.Console.WriteLine("NOD="+a);
System.Console.WriteLine("NOK="+(a*b)/a);
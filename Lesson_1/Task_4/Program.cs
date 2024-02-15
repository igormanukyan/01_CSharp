int a = 23;
int b = 4;
int c = 63;
int d = 62;
int e = 61;
int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}

System.Console.Write("Maximum is: ");
System.Console.WriteLine(max);
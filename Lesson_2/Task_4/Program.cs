int N = 10;
int [] array = { 1,4,5,3,66,33,6,5,60,23};
int i = 0;
int max = array[0];

while (i < N)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
System.Console.WriteLine(max);

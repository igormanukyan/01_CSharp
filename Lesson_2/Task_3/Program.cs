﻿int N = 10;
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int i = 0;

while (i < N)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");

    }
    i = i + 1;
}

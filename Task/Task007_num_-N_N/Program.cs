﻿// Показать числа от -N до N

int[] num = {-9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

int count = num.Length;
int i = 0;
while(i < count)
{
    Console.WriteLine(num[i]);
    i++;
}
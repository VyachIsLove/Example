int[] array = {1, 4, 5, 7, 8, 43, 45, 90};

int count = array.Length;
int position = 0;
 while (position < count) 
{
    Console.WriteLine($"{position}: {array[position]}");
    position ++;
}


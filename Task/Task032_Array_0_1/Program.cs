int[] array = new int[8];

int count = array.Length;
int i = 0;
while (i < count) 
{
    array[i] = new Random().Next(0, 2);
    Console.WriteLine(array[i]);
    i++;
}


//int a = 165;
//int b = 23;
//int c = 117;

//int max = a;
//if(b > max) max = b;
//if(c > max) max = c;

//Console.WriteLine("Max number "+ max);

int[] arr = {7, 5, 4, 8, 2, 7, 3, 6, 1};

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        
    }
}

SelectionSort(arr);
Console.Write($"maxPosition");

//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] arr = new int[12];

for (int i = 0; i < 12; i++)
{
    arr[i] = new Random().Next(0, 10);
    int sum = arr[i] + arr[i+1];

    Console.WriteLine(sum);

}
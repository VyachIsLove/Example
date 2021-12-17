// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a = new Random().Next(10, 99);
int x = 0;

Console.WriteLine(a);
Console.WriteLine();

for ( ;a !=0; a/= 10)
{
    int r = a % 10;
    if (r > x) x = r;
}

Console.WriteLine(x);

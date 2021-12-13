// Показать четные числа от 1 до N

int a = 1;
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
while (a < N+1)
{
    if (a % 2 == 0) Console.WriteLine(a);
    a++;
}
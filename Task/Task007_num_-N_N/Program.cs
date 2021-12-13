// Показать числа от -N до N

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int a = -N;
while(a < N+1)
{
    Console.WriteLine(a);
    a++;
}
// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
int result = numA / numB;
int result_sec = numB / numA;

if (result == numB)
{
    Console.WriteLine ("Второе число является корнем первого ");
}
else
if(result_sec == numA)
{
    Console.WriteLine ("Первое число является корнем второго ");
}
else 
{
    Console.WriteLine("Ни одно из чисел не является корнем другого");
}
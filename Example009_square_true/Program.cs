Console.Write ("Введите число, ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число, ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberA / numberB;
if (result == numberA)
{
    Console.WriteLine ("Не является корнем ");
}
else
{ 
    Console.WriteLine ("Ура, это корень!");
}
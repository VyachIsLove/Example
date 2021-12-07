int numberA = new Random().Next(1, 10);
int numberB = new Random().Next(1, 10);

int max = numberA;
int min = numberB;

if(numberA != numberB)
{
    if (numberA > max) max = numberA; 
    else min = numberA;
    if (numberB > max) max = numberB; 
    else min = numberB;

    Console.WriteLine ("Наибольшее число "+ max );
    Console.WriteLine ("Наименьшее число "+ min);
}
if(numberA == numberB)
{
    Console.WriteLine(max);
    Console.WriteLine("Числа равны");
}

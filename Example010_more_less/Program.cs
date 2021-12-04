int numberA = 10;
int numberB = 7;

int max = numberA;
int min = numberB;


if (numberA > max) max = numberA; 
else min = numberA;
if (numberB > max) max = numberB; 
else min = numberB;

Console.WriteLine ("Наибольшее число "+ max );
Console.WriteLine ("Наименьшее число "+ min);
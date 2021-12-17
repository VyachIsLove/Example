// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите число ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите делитель ");
int numB = Convert.ToInt32(Console.ReadLine());

int remain = numA % numB;

if(remain != 0) Console.WriteLine("Остаток равен "+ remain);
if(remain == 0) Console.WriteLine("Число кратно заданному.");

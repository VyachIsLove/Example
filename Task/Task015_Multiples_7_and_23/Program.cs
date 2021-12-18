// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int resA = num % 7;
int resB = num % 23;

if( resA == 0 ) Console.WriteLine("Число кратно 7");
else 
Console.WriteLine("Число не кратно 7");

if( resB == 0 ) Console.WriteLine("Число кратно 23");
else 
Console.WriteLine("Число не кратно 23");
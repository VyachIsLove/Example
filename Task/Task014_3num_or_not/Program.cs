// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число ");
string num = Console.ReadLine();

int a = num.Length; // длина числа 
int b = a - 2; 

if(a < 3)
{
    Console.WriteLine("Третья цифра в числе отсутствует.");
}
if(a == a)
{
    int n = num[num.Length - b] - '0';
    Console.WriteLine("Третья цифра числа " + n);
}


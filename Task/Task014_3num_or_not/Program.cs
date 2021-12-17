// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число ");
string num = Console.ReadLine();

if(num.Length == 3)
{
    int n = num[num.Length - 1] - '0';
    Console.WriteLine(n);
}
else if (num.Length > 3)
{
    int n = num[num.Length - 2] - '0';
    Console.WriteLine(n);
}
else
{
    Console.WriteLine("Третья цифра в числе отсутствует.");
}

// int n = num[num.Length -1] - '0';

// if(num.Length == 3) 
// Console.WriteLine(n);
// else (num.Length < 3);
// {
//     Console.WriteLine("Третья цифра в числе отсутствует.");
// }

// if(num.Length > 3) 
// int n = num[num.Length -2] - '0';
// Console.WriteLine(n);
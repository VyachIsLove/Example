// Удалить вторую цифру трёхзначного числа

Console.Write("Введите число: ");
string text = Console.ReadLine();
int n = text[text.Length - 3] - '0';
int a = text[text.Length - 1] - '0';

Console.Write(n); Console.Write(a);
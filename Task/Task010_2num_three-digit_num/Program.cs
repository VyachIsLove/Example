// Показать вторую цифру трёхзначного числа

Console.Write("Введите число: ");
string text = Console.ReadLine();
int n = text[text.Length - 2] - '0';

Console.WriteLine(n);
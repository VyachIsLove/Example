// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int day = new Random().Next(1, 7);
Console.WriteLine(day);
Console.WriteLine();

if ( day == 6 ) Console.WriteLine("Выходной!");
else

if ( day == 7 ) Console.WriteLine("Выходной!");
else
Console.WriteLine("Будний день");
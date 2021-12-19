// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Введите координату X ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y ");
int y = Convert.ToInt32(Console.ReadLine());

if ( x != 0 && y != 0)
{
    if ( x > 0 && y > 0)
    {
        Console.WriteLine("I четверть плоскости");
    }
        if ( x < 0 && y > 0 )
        {
            Console.WriteLine("II четверть плоскости");
        }
            if ( x < 0 && y < 0 )
            {
                Console.WriteLine("III четверть плоскости");
            }
                if ( x > 0 && y < 0 )
                {
                    Console.WriteLine("IV четверть плоскости");
                }
}
else 
Console.WriteLine("Произведение координат не должно ровняться 0");



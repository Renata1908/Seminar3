

Console.WriteLine("Введите координату Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату У");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0 )
{
    Console.WriteLine("Первая четверть");
}
else if(x < 0 && y > 0 )
{
    Console.WriteLine("Вторая четверть");
}
else if(x < 0 && y < 0 )
{
    Console.WriteLine("Третья четверть");
}
else if(x > 0 && y < 0 )
{
    Console.WriteLine("Четвертая четверть");
}
else if(x == 0 || y == 0)
{
        Console.WriteLine("Введена нулевая координата");
}




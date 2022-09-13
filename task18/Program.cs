Console.WriteLine("Число от 1 до 4");
int count = Convert.ToInt32(Console.ReadLine());



if(count == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if(count == 2)
{
    Console.WriteLine("x < 0 && y > 0 ");
}
else if(count == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if(count == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else 
{
        Console.WriteLine("Такой четверти не существует");
}

Console.WriteLine("Введите число N > 0:");
int n = Convert.ToInt32(Console.ReadLine());
int x = 0;

Console.WriteLine();


if(n > 0)
{
for (int i = 1; i <= n; i++)
{
    x = i * i;
    Console.WriteLine(x);
}
}
else
Console.WriteLine("Введено некорректное число");
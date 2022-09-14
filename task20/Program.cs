Console.WriteLine("Введите координату точки А: х1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А: у1");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки В: х2");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки В: у2");
double y2 = Convert.ToInt32(Console.ReadLine());

double dist = 0;
double sum = 0;

double a = x2 - x1;
double b = y2 - y1;

double quadrA = Math.Pow(a, 2);
double quadrB = Math.Pow(b, 2);

sum = quadrA + quadrB;

dist =Math.Sqrt(sum);

Console.WriteLine(dist);

















// x = Math.Pow(x, 2);

// y = Math.Sqrt(y);

// Console.WriteLine();

// Console.WriteLine(x);
// Console.WriteLine();
// Console.WriteLine(y);









 
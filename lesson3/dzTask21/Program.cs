Console.WriteLine("Введите кординату x точки 1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату y точки 1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату z точки 1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату x точки 2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату y точки 2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату z точки 2");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine(result);
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно целое число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c) 
{
    Console.WriteLine($"Max = {a}");
}
else if (b > a && b > c)
{
    Console.WriteLine($"Max = {b}");
}
else
{
    Console.WriteLine($"Max = {c}");
}
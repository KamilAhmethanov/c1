Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) 
{
    Console.WriteLine($"Max = {a}");
}
else
{
    Console.WriteLine($"Max = {b}");
}



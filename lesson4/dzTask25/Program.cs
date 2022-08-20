Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int c = a;
while (b > i)
{
    c = c * a;
    i++;
}
Console.WriteLine(c);
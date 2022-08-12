Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (num > 1)
{
    while (i <= num)
    {
        int z = i * i * i;
        Console.WriteLine($"{i}  {z}");
        i++;
    }
}
else Console.WriteLine("Число меньше 1");
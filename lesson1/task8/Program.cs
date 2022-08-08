Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
while (a > b + 1)
{
    b = b + 2;
    Console.Write($"{b} ");
}
if (a < 1)
{
    Console.WriteLine("Ошибка");
}
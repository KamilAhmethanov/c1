Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int sm1 = 0;
while (num > 0)
{
    sm1 = num % 10;
    num /= 10;
    sum = sum + sm1;
}
Console.WriteLine(sum);
Console.WriteLine("Введите любое пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 10000;
int num2 = num / 1000 % 10;
int num4 = num % 100 / 10;
int num5 = num % 10;
if (num > 9999)
{
    if (num1 == num5 && num2 == num4) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else Console.WriteLine("Число не является пятизначным");
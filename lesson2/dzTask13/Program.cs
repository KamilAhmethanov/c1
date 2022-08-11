//int number = new Random().Next(-999999999, 999999999);
//int number3 = number / 100;
//Console.WriteLine(number);
//if (number3 == 0) Console.WriteLine("третьей цифры нет");
//if (number3 > 0) Console.WriteLine(number3 % 10);
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int nonumber3 = number / 100;
int number3 = number / 100;
if (nonumber3 == 0) Console.WriteLine("третьей цифры нет");
if (nonumber3 > 0) while (number > 1000 || number < -1000)
    {
        number = number / 10;
    }
Console.WriteLine(number % 10);
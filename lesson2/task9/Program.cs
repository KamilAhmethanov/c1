int a = new Random().Next(10, 99);
int a1 = a / 10;
int a2 = a % 10;
int Max = a1;
Console.WriteLine($"Случайное число в диапозоне от 10 до 99: {a}");
if (a2==a1) Console.WriteLine("Цифры равны");
else if (a2>a1) Console.WriteLine($"Наибольшая цифра числа: {a2}");
else
{
    Console.WriteLine($"Наибольшая цифра числа {a} : {a1}");
}
int number = new Random().Next(100, 999);
int number2 = number / 10 % 10;
Console.WriteLine($"Случайное число в диапозоне от 100 до 999: {number}");
Console.WriteLine($"Вторая цифра случайного числа {number} -> {number2}");
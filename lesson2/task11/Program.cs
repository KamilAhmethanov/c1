int number = new Random().Next(100, 999);
int number1 = number / 100;
int number3 = number % 10;
Console.WriteLine($"Случайное число в диапозоне от 100 до 999: {number}");
Console.WriteLine($"Случайное число {number} без второй цифры: {number1}{number3}");
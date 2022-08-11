Console.WriteLine("Введите число от 1 до 7 :");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 8 || day <= 0) Console.WriteLine("Ошибка");
else if (day > 0 && day < 6) Console.WriteLine("нет");
else if (day > 5 && day < 8) Console.WriteLine("да");
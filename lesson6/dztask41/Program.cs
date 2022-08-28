Console.WriteLine("Введите числа c пробелами: ");
int[] intArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < intArray.Length; i++)
{
    if (intArray[i] > 0) count++;
}
Console.WriteLine($"Чисел большe нуля -> {count}");

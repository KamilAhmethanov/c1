int[] NewArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 7; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
int[] Array = NewArray();
void PrintArray()
{
    for (int i = 0; i < 7; i++)
    {
        Console.Write($" {Array[i]}, ");
    }
}
PrintArray();
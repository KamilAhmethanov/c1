Console.WriteLine("m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] Array = new double[m, n];
void CreateArray(double[,] Array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}
CreateArray(Array);
void WriteArray(double[,] Array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double nmbs = Math.Round(Array[i, j], 1);
            Console.Write($"{nmbs} ");
        }
        Console.WriteLine();
    }
}
WriteArray(Array);

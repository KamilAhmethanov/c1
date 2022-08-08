int a = new Random().Next(10, 99);
int a1 = a / 10;
int a2 = a % 10;
int Max = a1;
Console.WriteLine(a);
if (a2>=a1) Console.WriteLine(a2);
else
{
    Console.WriteLine(a1);
}
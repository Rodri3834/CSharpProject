int a = -9;
int b = -3;
int max;
int min;
if(a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.Write("Максимальное число - ");
Console.WriteLine(max);
Console.Write("Минимальное число - ");
Console.WriteLine(min);
Console.Write("Введите число А: ");
double a = double.Parse(Console.ReadLine()!);

Console.Write("Введите натуральное число В: ");
int b = int.Parse(Console.ReadLine()!);
double result = 1;
double power (double c, int d) 
{   for (int i=1;i<=b;i++)
    {
        result=a*result;
    }
    return result;
}
double p=power(a,b);
Console.Write($"Число А в степени В равно: {p}");
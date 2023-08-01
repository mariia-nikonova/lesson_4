Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine()!);
int tmp = 0;
int result = 0;
Console.Write($"Сумма цифр числа {a}: ");

int sum(int c)
{
    if (a < 10) Console.Write($"Сумма цифр числа: {a}");
    else
        while (a / 10 != 0)
        {
            tmp = a % 10;
            a = a / 10;
            result = result + tmp;
        }
    result = result + a;
    return result;
}
int s = sum(a);
Console.Write(s);
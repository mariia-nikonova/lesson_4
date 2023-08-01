Random rand = new Random();
int s = 8;
Console.Write("[ ");

int[] myArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(40);
        Console.Write($"{array[i]} ");
    }
    return array;
}
int[] myArr = myArray(s);
Console.Write("]");

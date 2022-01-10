// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double [] EnterArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = (new Random()).Next(0, 11400) / 1000.0;
    }
    return array;
}

void PrintArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($" {Array[i]} ");
    }
}

double FindMax(double[] NewArr)
{
    double Max = NewArr[0];
    for (int i = 1; i < NewArr.Length; i++)
    {
        if (NewArr[i] > Max)
            Max = NewArr[i];
    }
    return Max;
}

double FindMin(double[] Arr)
{
    double Min = Arr[0];
    for (int i = 1; i < Arr.Length; i++)
    {
        if (Arr[i] < Min)
            Min = Arr[i];
    }
    return Min;
}

Console.Write($"Введите длину массива: ");
int N = int.Parse(Console.ReadLine() ??"0");
double [] NewArray = EnterArray(N);
PrintArray(NewArray);
double max = FindMax(NewArray);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент равен {max}");
double min = FindMin(NewArray);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент равен {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом составляет: {max - min}");
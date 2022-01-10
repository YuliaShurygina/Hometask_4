// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] EnterArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(100,1000);
    return array;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
        Console.Write($"  {Array[i]}  ");
}

int EvenNumbers(int[] SomeArray)
{
    int count = 0;
    for (int i = 0; i < SomeArray.Length; i++)
    {
        if (SomeArray[i] % 2 == 0)
            count = count + 1;
    }
    return count;
}

int[] SpecifiedArray = EnterArray(15);
PrintArray(SpecifiedArray);
Console.WriteLine();
int EvenQuantity = EvenNumbers(SpecifiedArray);
Console.WriteLine($"Количество четных чисел в массиве равно {EvenQuantity} ");
Console.WriteLine($"Количество нечетных чисел в массиве равно {SpecifiedArray.Length - EvenQuantity} ");

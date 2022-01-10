// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] EnterArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100,101);
    }
    return array;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
}

int SectionNumber(int[] SomeArray)
{
    int count = 0;
    for (int i = 0; i < SomeArray.Length; i++)
    {
        if ((SomeArray[i] >= 10) & (SomeArray[i] <= 99))
            count ++;
    }
    return count; 
}

int[] SpecifiedArray = EnterArray(123);
PrintArray(SpecifiedArray);
Console.WriteLine();
int Quantity = SectionNumber(SpecifiedArray);
Console.WriteLine($"Количество элементов массива, входящих в отрезок [10,99], равно {Quantity}");
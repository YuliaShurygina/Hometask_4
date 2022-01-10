// Найти сумму чисел одномерного массива стоящих на нечетной позиции (считаю первый элемент массива первым, а не нулевым)
int [] EnterArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = int.Parse(Console.ReadLine() ??"0");
    }
    return array;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($" {Array[i]} ");
    }
}

int OddIndexes(int[] someArray)
{
    int Sum = 0;
    for(int i = 0; i < someArray.Length; i = i + 2)
    {
        Sum = Sum + someArray[i];
    }
    return Sum;
}

int[] SpecifiedArray = EnterArray(10);
Console.WriteLine();
Console.Write($"Заданный массив: ");
PrintArray(SpecifiedArray);
Console.WriteLine();
int SumOddIndexes = OddIndexes(SpecifiedArray);
Console.WriteLine($"Сумма чисел массива, стоящих на нечетных позициях, равна {SumOddIndexes} ");

// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.(Если длина массива нечетная, то я приняла, что элемент без пары умножается сам на себя)
int [] EnterArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1,11);
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

int[] multiply(int[] SomeArray)
{
    int length = SomeArray.Length / 2;
    if (SomeArray.Length % 2 == 0)
    {
       int[] newArray = new int[length]; 
       for (int i = 0; i < length; i++)
       {
            newArray[i] = SomeArray[i]*SomeArray[SomeArray.Length - 1 - i];
       }
       return newArray; 
    }
    else
    {
        int[] newArray = new int[length+1];
        for (int i = 0; i <= length; i++)
        {
            newArray[i] = SomeArray[i]*SomeArray[SomeArray.Length - 1 - i];
        }
        return newArray; 
    }
    
}
Console.Write($"Введите длину массива: ");
int N = int.Parse(Console.ReadLine() ??"0");
int [] SpecifiedArray = EnterArray(N);
Console.WriteLine($"Заданный массив: ");
PrintArray(SpecifiedArray);
Console.WriteLine();
Console.Write($"Произведение пар чисел массива: ");
int[] multiplyArray = multiply(SpecifiedArray);
PrintArray(multiplyArray);

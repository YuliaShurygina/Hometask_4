// Определить, присутствует ли в заданном массиве, некоторое число
int[] EnterArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите { i+1 } элемент заданного массива: ");
        array[i] = int.Parse(Console.ReadLine() ?? "0");
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

bool Contain(int[] someArray, int n)
{
        for (int i = 0; i < someArray.Length; i++)
    {
        if (someArray[i] == n) 
            return true;
    }
        return false;
}



int[] SpecifiedArray = EnterArray(5);
Console.WriteLine();
Console.Write($"Заданный массив: ");
PrintArray(SpecifiedArray);
Console.WriteLine();
Console.Write($"Введите некоторое число n = ");
int N = int.Parse(Console.ReadLine() ??"0");
bool Result = Contain(SpecifiedArray, N);
if (Result == true)
    Console.WriteLine($"Заданный массив содержит число {N}");
else
{
    Console.WriteLine($"В заданном массиве число {N} отсутствует");
}
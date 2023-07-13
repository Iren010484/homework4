/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] GetBinArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

Console.Clear();
Console.Write("Массив из 8 элементов: ");
int num = 8;
int[] array = GetBinArray(num);

Console.Write($"[{String.Join(", ", array)}]");

Console.Write($"   [");
for (int i = 0; i < num - 1; i++)
{
    Console.Write($"{array[i]}, ");
}

Console.Write($"{array[num - 1]}]");


Console.WriteLine();
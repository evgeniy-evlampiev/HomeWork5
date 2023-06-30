
// Задача 38: Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [22, 42, 15, 77, 65] => 77 - 15 = 62**


int[] array = GetArray(8, 10, 99);
Console.WriteLine(String.Join(", ", array));

Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {GetDiff(array)}");

int GetDiff(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
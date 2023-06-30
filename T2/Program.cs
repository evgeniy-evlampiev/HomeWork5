// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

int[] array = GetArray(14,0,999);
Console.WriteLine(String.Join(", ",array));

Console.WriteLine($"сумму элементов, стоящих на нечётных индексах равна {GetSum(array)}");

int GetSum(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 !=0) sum += array[i];
    }
    return sum;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

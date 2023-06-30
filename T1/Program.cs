// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(" , ", array)}]");
int count = 0;

foreach(int el in array){
    count += el % 2==0 ? 1 : 0;
}
Console.WriteLine($"количество чётных чисел в массиве = {count}");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 1000);
    }
    return result;
}

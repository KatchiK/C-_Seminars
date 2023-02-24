/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
Console.WriteLine("Программа создаёт массив, заполняет его случайными трёхзначными числами и подсчитывает в нём количество чётных чисел.");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size]; // Создание массива на size элементов
    // Если size = 12, то массив состоит из 12 нулей
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result; // Вернули массив на size элементов, заполненный числами
    // от minValue до maxValue
}

int NumOfEvenNum(int[] array)
{
    int sizeArray = array.Length;
    int count = 0;
    for (int i = 0; i < sizeArray; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(20, 100, 999);
Console.WriteLine($"В массиве\n[{String.Join("; ", array)}]\n{NumOfEvenNum(array)} чётных чисел.");

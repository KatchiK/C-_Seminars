/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();
Console.WriteLine("Программа создаёт массив, заполняет его случайными числами и находит сумму чисел на нечётных позициях.");

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

int SumOfElements(int[] array)
{   int sum = 0;
    int sizeArray = array.Length;
    for (int i = 1; i < sizeArray; i=i+2)
    {
        sum = sum + array[i];        
    }
    return sum;
}

int[] array = GetArray(20, -100, 100);
Console.WriteLine($"В массиве\n[{String.Join("; ", array)}]\nсумма чисел на нечётных позициях равняется {SumOfElements(array)}.");
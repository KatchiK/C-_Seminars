/*Задача 38:
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
Используйте NextDouble().
*/

Console.Clear();
Console.WriteLine("Программа создаёт массив случайных вещественных чисел и находит разницу между максимальным и минимальным элементами массива.");

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size]; // Создание массива на size элементов
    // Если size = 12, то массив состоит из 12 нулей
    int intRandomNumber = 0;
    double doubleRandomNumber = 0;
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        doubleRandomNumber = new Random().NextDouble();
        intRandomNumber = new Random().Next(minValue, maxValue+1);
        result[i] = doubleRandomNumber * intRandomNumber;

    }
    return result; 
}

double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    int arraySize = array.Length;

    for (int i = 1; i < arraySize; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        else if (min > array[i])
        {
            min = array[i];
        }

    }
    double diff = max - min;
    Console.WriteLine($"Минимальный элемент массива:{min}\nМаксимальный элемент массива:{max}");
    return diff;
}

double[] array = GetArray(10, -1000, 1000);
Console.WriteLine($"В массиве\n[{String.Join("; ", array)}]\nразница между максимальным и минимальным элементами массива составляет {DiffMaxMin(array)}.");


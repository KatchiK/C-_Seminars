/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] array = GetArray(123, -100, 100);

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

int size = array.Length;
int count = 0;

for (int i = 0; i < size; i++)
{
    if (array[i]>=10 && array[i] <=99)
    {
        count++;
    }
}

Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Количество чисел от 10 до 99:{count}");
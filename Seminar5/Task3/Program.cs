/*Задача 33: Задайте массив. 
Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] array = GetArray(12, -9, 9);

// Создание массива
// 3 параметра: 1 параметр - размер массива size
// 2 параметр: нижняя граница рандома (-9), верхняя граница рандома (9) 
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

Console.WriteLine
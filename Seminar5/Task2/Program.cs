/*Задача 32: 
Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

int[] InverseArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        inputArray[i] *= (-1); // inputArray[i] = inputArray[i] * (-1)
    }
    return inputArray;
}
Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Перевернутый массив:: [{String.Join("; ", InverseArray(array))}]");
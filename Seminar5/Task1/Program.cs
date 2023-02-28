/*Задача 31:
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/
int[] array = GetArray(12, -9, 9);
Console.WriteLine($"Массив: [{String.Join(";", array)}]");
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

int sumPositive = 0; // Сумма положительных чисел
int sumNegative = 0; // Сумма отрицательных чисел
int size = array.Length;
for (int i = 0; i < size; i++)
{
    if (array[i] > 0)
    {
        //sumPositive = sumPositive + array[i];
        sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i]; // sumNegative = sumNegative + array[i]
    }
}
Console.WriteLine($"Сумма положительных чисел: {sumPositive}, отрицательных чисел: {sumNegative} ");
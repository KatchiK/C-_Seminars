/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

int[] GetBinaryArray(int size)
{
    int[] array = new int[size]; // Получается массив на size(8) элементов
    // Массив состоит из 8 нулей
    // size = array.Length
    for (int i = 0; i < size; i++)
    {
        // array[i] = new Random().Next(0,2);
        array[i] = new Random().Next(2); // [0;1]
        // array[0] = 0, array[1] = 0, array[2] = 0
    }
    return array;
}

int[] resultArray = GetBinaryArray(8);
double[] test = new double[10]; 

for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i] + "\t"); 
}

Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");
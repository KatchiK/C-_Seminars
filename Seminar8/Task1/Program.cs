/* vЗадача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

// 1. Заполним таблицу
int[,] resultMatrix = GetMatrix(3, 3, 0, 10); //3 стр, 3 стлбц, числа от 0 до 10 включительно
// Квадратная матрица: строки = столбцы(5 = 5)

// 2. Печать матрицы
PrintMatrix(resultMatrix);

// Меняем 1 и последнюю строчку местами
Console.WriteLine("Результирующая матрица: ");
ChangeRows(resultMatrix);
PrintMatrix(resultMatrix); // Печатает матрицу с замененной 1 и последней строчкой

/// <summary>
/// Этот метод заполняет двумерный массив
/// числами от min до max (общее описание)
/// </summary>
/// <param name="rows">Количество строк (описывается параметр)</param>
/// <param name="cols">Количество столбцов (описывается параметр)</param>
/// <param name="min">Минимальное число для рандома(описывается параметр)</param>
/// <param name="max">Максимальное число для рандома(описывается параметр)</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
int[,] GetMatrix(int rows, int cols, int min, int max) // параметры (4)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
/// <summary>
/// Метод печатает матрицу, которую передали на вход
/// </summary>
/// <param name="inputMatrix"> Двумерный массив или таблица </param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // Строчки
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++) // Столбцы
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// Методы: PascalCase (FillArray, FillMatrix)
// camelCase (firstNumber, inputMatrix)
/// <summary>
/// Метод меняет 1 и последнюю строчку местами
/// </summary>
/// <param name="matr"> матрица (двумерный массив) </param>
void ChangeRows(int[,] matr)
{
    int lastRow = matr.GetLength(0) - 1; // Индекс самой последней строчки :Р
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int temp = matr[0, i]; // Элемент таблицы из 0 строчки и i столбца
        matr[0, i] = matr[lastRow, i];
        //  Элемент из 0 строчки и i столбца = элементу из посл. строчки и i столбца
        matr[lastRow, i] = temp; 
        // элемент из посл. строчки и i столбца = temp = Элемент таблицы из 0 строчки и i столбца
    }
}

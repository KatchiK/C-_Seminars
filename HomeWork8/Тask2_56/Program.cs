/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue) // Создание двумерного массива с ранодмными числами.
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr) // Печатаем двумерный массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write(matr[i, m] + "\t");
        }
        Console.WriteLine();
    }
}

void LineWithMinSumm(int[,] matr)// Находим строку с минимальной суммой элементов
{
    int minSumLine = int.MaxValue;
    int minSumLineIndex = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sumLine = 0;
        for (int j = 0; j <  matr.GetLength(1); j++)
        {
            sumLine = sumLine + matr[i,j];            
        }
        if (sumLine < minSumLine)
        {
            minSumLine = sumLine;
            minSumLineIndex = i;
        }
    }
    Console.WriteLine($"\n{minSumLineIndex}-я строка в массиве с наименьшей суммой элементов\n");
}
int[,] matrix = GetMatrix(7, 3, 0, 5);
Console.WriteLine("\nИсходный массив:");
PrintMatrix(matrix);
LineWithMinSumm(matrix);
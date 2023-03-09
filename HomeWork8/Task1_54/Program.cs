/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue) // Создание двумерного массива с рандомными числами.
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

int[,] OrderingLines(int[,] matr)//Сортируем числа в строках матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)//обходим строки
    {
        for (int n = 0; n < matr.GetLength(1); n++)//меняем максимально число в строке и число по порядку местами
        {
            int maxNum = matr[i, n];
            int indexCollMaxNum = n;
            for (int j = 1 + n; j < matr.GetLength(1); j++)// находим максимальное число в строке и его индекс
            {
                if (matr[i, j] > maxNum)
                {
                    maxNum = matr[i, j];
                    indexCollMaxNum = j;
                }
            }
            int tempNum = matr[i, n];
            matr[i, n] = maxNum;
            matr[i, indexCollMaxNum] = tempNum;
        }
    }
    return matr;
}

int[,] matrix = GetMatrix(7, 5, -100, 100);
Console.WriteLine("\nИсходная матрица:");
PrintMatrix(matrix);
Console.WriteLine("\nОтсортированная матрица:");
PrintMatrix(OrderingLines(matrix));

/*Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.Clear();

double[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    double[,] matrix = new double[rows, cols]; // [строчка, столбец]
    for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
    {
        for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1) * new Random().NextDouble();
        }
    }
    return matrix; // Вернули заполненную табличку
}

void PrintMatrix(double[,] matr) // Печатаем двумерный массив
{
    for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам
    {
        for (int m = 0; m < matr.GetLength(1); m++) // Проход по столбцам
        {
            Console.Write(matr[i, m] + "\t"); // "\t" = 4 пробела или tab
        }
        Console.WriteLine();
    }
}

double[,] resultMatrix = GetMatrix(10, 4, -100, 100);
PrintMatrix(resultMatrix);
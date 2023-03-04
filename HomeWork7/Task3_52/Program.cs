/*Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue) // Создание двумерного массива с ранодмными числами.
{
    int[,] matrix = new int[rows, cols]; // [строчка, столбец]
    for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
    {
        // i,j,m,k - индексы
        for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix; // Вернули заполненную табличку
}

void PrintMatrix(int[,] matr) // Печатаем двумерный массив
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

void ArithmetiсMeanColumn(int[,] matr)
{
    Console.Write("Среднее арифметическое по столбцам: ");
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double arithMean = new double();
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            arithMean = arithMean + matr[j, i];
        }
        arithMean = arithMean / matr.GetLength(0);
        Console.Write($"{arithMean}; ");
    }
}


int[,] matrix = GetMatrix(5, 3, 0, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);
ArithmetiсMeanColumn(matrix);
/*Задача 51: Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

void DiagonalSum(int[,] matr)
{
    int sum = 0;
    int length = new int();

    if (matr.GetLength(0) > matr.GetLength(1)) length = matr.GetLength(1);
    else length = matr.GetLength(0);

    for (int i = 0; i < length; i++)
    {
        sum = sum + matr[i, i];
    }
    Console.WriteLine($"Сумма чисел по главной диагонали массива составляет: {sum}");
}

int[,] matrix = GetMatrix(6, 4, 0, 10);
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);
DiagonalSum(matrix);
/* Задача 55: 
Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

int[,] matrix = GetMatrix(4,4,0,100);
PrintMatrix(matrix);

ChangeMatrix(matrix);
Console.WriteLine("Результирующая матрица");
PrintMatrix(matrix);


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

void ChangeMatrix(int[,] matr)
{
    int temp;
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        // i,j,m,k - индексы
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            temp = matr[i,j];
            matr[i,j] = matr[j,i];
            matr[j,i] = temp;
        }

    }

}



/*Задача 58: 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

void ProductMatrix(int[,] matrA, int[,] matrB)//перемножаем матрицы
{
    int rowsResultMatr = matrA.GetLength(0);
    int colsResultMatr = matrB.GetLength(1);

    int[,] resultMatr = new int[rowsResultMatr, colsResultMatr];
    if (matrA.GetLength(1) == matrB.GetLength(0))
    {
        for (int i = 0; i < rowsResultMatr; i++)
        {
            for (int j = 0; j < colsResultMatr; j++)
            {
                for (int n = 0; n < matrA.GetLength(1); n++)
                {
                    resultMatr[i, j] = resultMatr[i, j] + (matrA[i, n] * matrB[n, j]);
                }

            }
        }
        Console.WriteLine($"\nМатрица А * Матрица B =");
        PrintMatrix(resultMatr);
    }
    else
    {
        Console.WriteLine("\nДанные матрицы перемножить нельзя");
    }
}


int[,] matrixA = GetMatrix(4, 3, 0, 10);
int[,] matrixB = GetMatrix(3, 6, 0, 10);
Console.WriteLine($"\nМатрица А:");
PrintMatrix(matrixA);
Console.WriteLine($"\nМатрица B:");
PrintMatrix(matrixB);
ProductMatrix(matrixA, matrixB);




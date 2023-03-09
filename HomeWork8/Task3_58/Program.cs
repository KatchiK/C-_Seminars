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

bool PossibleMatrixProduction(int[,] matrA, int[,] matrB)
{   
    if (matrA.GetLength(1) == matrA.GetLength(0))
    {
        
    }
}

int[,] ProductMatrix(int[,] matrA, int[,] matrB)//перемножаем матрицы
{
    if (matrA.GetLength(1) != matrA.GetLength(0)) 
    {
        Console.WriteLine("Данные матрицы перемножить нельзя");
        break;
    }
    else
    {
        for (int i = 0; i < length; i++)
        {
            
        }
    }

}



int [,] matrixA = GetMatrix(3,3, 0,10);
int [,] matrixB = GetMatrix(3,3, 0,10);
Console.WriteLine($"\nМатрица А:");
PrintMatrix(matrixA);
Console.WriteLine($"\nМатрица B:");
PrintMatrix(matrixB);



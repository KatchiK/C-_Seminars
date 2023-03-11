/*Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int[,] GetMatrix(int rows, int cols) // Создание двухмерного массива
{
    int[,] matrix = new int[rows, cols];
    int y = 0;
    int x = 0;
    int num = 1;
    int countSize = 0;

    while (y != 1 || x != 1)
    {
        if (countSize == 0)
        {
            while (x < cols - 1)
            {
                matrix[y, x] = num;
                num++;
                x++;
            }
        }
        else
        {
            while (x < cols - countSize)
            {
                matrix[y, x] = num;
                num++;
                x++;
            }
        }


        countSize++;
        while (y < rows - countSize)
        {
            matrix[y, x] = num;
            num++;
            y++;
        }

        while (x >= countSize)
        {
            matrix[y, x] = num;
            num++;
            x--;
        }
        countSize++;

        while (y >= countSize)
        {
            Console.Write($"countSize={countSize}; Yобр={y} \n");//служебная печать
            matrix[y, x] = num;
            num++;
            y--;
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

int[,] resultMatrix = GetMatrix(6, 8);
PrintMatrix(resultMatrix);
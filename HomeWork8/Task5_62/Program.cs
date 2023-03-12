/*Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int[,] GetMatrix(int sizeArr) // Создание двухмерного массива c заполнением простыми числами по спирали.
{
    int[,] matrix = new int[sizeArr, sizeArr];
    int y = 0;
    int x = 0;
    int num = 1;
    int countSize = 1;


    for (int j = 0; j < (sizeArr + 1) / 2; j++)
    {
        if (countSize == 1)
        {
            for (int i = 0; i < sizeArr - countSize; i++)
            {
                matrix[y, x] = num;
                x++;
                num++;
            }
        }
        else
        {
            for (int i = 0; i < sizeArr - countSize; i++)
            {
                matrix[y, x] = num;
                x++;
                num++;
            }
            countSize++;
        }
        for (int i = 0; i < sizeArr - countSize; i++)
        {
            matrix[y, x] = num;
            y++;
            num++;
        }
        for (int i = 0; i < sizeArr - countSize; i++)
        {
            matrix[y, x] = num;
            x--;
            num++;
        }
        countSize++;
        Console.WriteLine($"countSize({countSize})");
        for (int i = 0; i < sizeArr - countSize; i++)
        {
            matrix[y, x] = num;
            y--;
            num++;
        }
        if (countSize >= sizeArr)
        {
            matrix[y, x] = num;
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

int[,] resultMatrix = GetMatrix(8);
PrintMatrix(resultMatrix);
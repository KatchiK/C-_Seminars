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
    int countCicle = 1;

    while (rows - countSize >= 1 && cols - countSize >= 1)

    {
        Console.WriteLine();
        if (countSize == 0)
        {
            while (x < cols - 1)
            {
                matrix[y, x] = num;
                num++;
                x++;
            }
            Console.WriteLine($"Цикл№{countCicle}; countSize ={countSize}; (y,x)=({y},{x}); Число={num} ");
            countSize++;
        }
        else
        {
            while (x < cols - countSize)
            {
                matrix[y, x] = num;
                num++;
                x++;
            }
            Console.WriteLine($"Цикл№{countCicle}; countSize ={countSize}; (y,x)=({y},{x}); Число={num} ");
        }

        //countSize++; - может он нужен???
        Console.WriteLine($"Цикл№{countCicle}; countSize ={countSize}; (y,x)=({y},{x}); Число={num} ");
        while (y < rows - countSize)
        {
            matrix[y, x] = num;
            num++;
            y++;
        }
        Console.WriteLine($"Цикл№{countCicle}; countSize ={countSize}; (y,x)=({y},{x}); Число={num} ");
        while (x >= countSize)
        {
            Console.Write($"countSize={countSize} x={x} ;");//служебная печать
            matrix[y, x] = num;
            num++;
            x--;
            Console.Write($"countSize={countSize} x(после --)={x} ;");//служебная печать
        }

        countSize++;
        Console.WriteLine($"Цикл№{countCicle}; countSize ={countSize}; (y,x)=({y},{x}); Число={num} ");
        while (y >= countSize)
        {
            // Console.Write($"countSize={countSize}; Yобр={y} \n");//служебная печать
            matrix[y, x] = num;
            num++;
            y--;
        }
        Console.WriteLine($"Цикл№{countCicle}; countSize ={countSize}; (y,x)=({y},{x}); Число={num} ");
        //Console.Write($"countSize={countSize}; Yобр={y} \n");
        countCicle++;

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

int[,] resultMatrix = GetMatrix(4, 4);
PrintMatrix(resultMatrix);
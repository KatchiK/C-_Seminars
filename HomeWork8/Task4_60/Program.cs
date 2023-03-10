/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] GetArray3d(int axisX, int axisY, int axisZ, int minValue, int maxValue) // Создание трёхмерного массива с рандомными числами.
{
    int[,,] arr3d = new int[axisX, axisY, axisZ];
    for (int x = 0; x < axisX; x++)
    {
        for (int y = 0; y < axisY; y++)
        {
            for (int z = 0; z < axisZ; z++)
            {
            NewRandom:
                arr3d[x, y, z] = new Random().Next(minValue, maxValue + 1);
                for (int x1 = 0; x1 < axisX; x1++)// Проверка на повтор числа.
                {
                    for (int y1 = 0; y1 < axisY; y1++)
                    {
                        for (int z1 = 0; z1 < axisZ; z1++)
                        {
                            if (x == x1 && y == y1 && z == z1)
                            {
                                goto Next;
                            }
                            else
                            {
                                if (arr3d[x1, y1, z1] == (arr3d[x, y, z]))
                                {
                                    goto NewRandom;
                                }
                            }
                        Next:;
                        }
                    }
                }
            }
        }
    }
    return arr3d;
}

void PrintMatrix(int[,,] arr3d) // Печатаем трехмерный массив
{
  Console.WriteLine();
    for (int x = 0; x < arr3d.GetLength(0); x++)
    {
        for (int y = 0; y < arr3d.GetLength(1); y++)
        {
            for (int z = 0; z < arr3d.GetLength(2); z++)
            {
                Console.Write($"{arr3d[x, y, z]}({x},{y},{z})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array3d = GetArray3d(3, 3, 3, 0, 27);
PrintMatrix(array3d);

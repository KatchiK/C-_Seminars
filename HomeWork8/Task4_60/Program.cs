/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] GetMatrix(int axisX, int axisY, int axisZ, int minValue, int maxValue) // Создание трёхмерного массива с рандомными числами.
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

        if (x != 0 && y != 0 && z != 0)
        {
          for (int x1 = 0; x1 < x; x1++)// Проверка на повтор числа.
          {
            Console.Write(x1);
            for (int y1 = 0; y1 < y; y1++)
            {
              Console.Write(y1);
              for (int z1 = 0; z1 < z; z1++)
              {
                Console.Write(z1 + "\t");
                if (arr3d[x, y, z] == arr3d[x1, y1, z1])
                {
                  Console.Write($"{arr3d[x, y, z]} ");
                  goto NewRandom;
                }
              }
            }
          }
        }


      }

    }
  }
  Console.WriteLine();
  return arr3d;
}

void PrintMatrix(int[,,] arr3d) // Печатаем 3 массив
{
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

int[,,] array3d = GetMatrix(3, 3, 3, 0, 100);
PrintMatrix(array3d);

/*Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1(строчка) 7 (столбец) -> такого числа в массиве нет
*/

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
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

void OutputСellСontents(int[,] inMatr, int iRow, int iCol)//Нахождение значения ячейки по адресу
{
    if (iRow > inMatr.GetLength(0) || iCol > inMatr.GetLength(1))
    {
        Console.WriteLine($"Числа по адресу ({iRow},{iCol}) в массиве нет, да и адреса такого в этом массиве нет!)");
    }
    else
    {
        Console.WriteLine($"По адресу ({iRow},{iCol}) в массиве находится число: {inMatr[iRow, iCol]}");
    }
}

int EnteringNumber(string text)//Метод ввода простого числа, проверки на число "int"
{
    Console.WriteLine(text);
EnterNumber:
    int num = 0;
    bool isNum = int.TryParse(Console.ReadLine(), out num);
    if (isNum == false)
    {
        Console.WriteLine("Введенное значение не является простым числом. Повторите ввод числе ещё раз:");
        goto EnterNumber;
    }
    return num;
}

int indexRow = EnteringNumber("Введите номер строки:");
int indexCol = EnteringNumber("Введите номер столбца:");
int[,] matrix = GetMatrix(6, 3, -100, 100);
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);
OutputСellСontents(matrix, indexRow, indexCol);

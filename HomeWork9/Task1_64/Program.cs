/*Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.WriteLine("Введите натуральное число >=2");
int N = Convert.ToInt32(Console.ReadLine());

string reduceNumber(int startNum, int endNum)
{
    if (startNum == endNum) return startNum.ToString();

    return (startNum + ", " + reduceNumber(startNum - 1, endNum));
}

Console.WriteLine(reduceNumber(N, 1));


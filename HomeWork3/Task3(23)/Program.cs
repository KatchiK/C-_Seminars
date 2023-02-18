/*
Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
Console.WriteLine("Эта программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine("Введите число от 2 до ~: ");

EnterNumber:
var stringN = Console.ReadLine();
int N;
bool isN = int.TryParse(stringN, out N);

if (isN == false || N < 2)
{
    Console.WriteLine($"Введённое значение \"{stringN}\" не принадлежит множеству чисел от 2 до ~.\nВведите число ещё раз:");
    goto EnterNumber;
}

Console.WriteLine("Числа в кубе от 1 до " + N + ":");
for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}



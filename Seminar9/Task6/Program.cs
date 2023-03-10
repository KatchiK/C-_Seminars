/*Задача 67: 
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int num)
{
    // Базовый
    if (num == 0) return 0; // К результату добавляется 0
    // Рекурсивный случай
    return (num % 10 + SumNumbers(num / 10));
}

Console.WriteLine(SumNumbers(number));
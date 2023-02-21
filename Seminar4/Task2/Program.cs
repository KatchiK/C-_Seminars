// See https://aka.ms/new-console-template for more information
/*Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Console.WriteLine("Введите число А:");
int limit = Convert.ToInt32(Console.ReadLine());
int GetSum(int A)
{
int sum = 0;
sum = (A*(A+1))/2;
Console.WriteLine(sum);
return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {limit} = {GetSum(limit)}");


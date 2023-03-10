/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

int GetPower(int number, int power)
{
    // Базовый случай
    if(power == 0) return 1; // Число в 0 степнени = 1
    if(power == 1) return number;// Число в первой степени = число
    return (number * GetPower(number, power - 1));
}
Console.WriteLine($"Число {number} в степени {degree}: {GetPower(number, degree)}");
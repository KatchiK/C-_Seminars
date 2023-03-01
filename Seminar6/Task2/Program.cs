/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/


Console.WriteLine("Введите через кнопку Интер 3 числа");
int A=Convert.ToInt32(Console.WriteLine());
int B=Convert.ToInt32(Console.WriteLine());
int C=Convert.ToInt32(Console.WriteLine());
if ((A+B>C)&&(A+C>B)&&(C+B>C))
{
    Console.WriteLine("Треугольник возможен");
}
else
{
    Console.WriteLine("Треугольник не возможен");
}

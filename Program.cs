// Напишите программу, которая на вход принимает число и выдаёт его квадрат
// (число умноженное на само себя).

// Например:
// 4-> 16
// - 3-> 9
// - 7-> 49

//int number;

/* ////////////////////////////
Console.Write("Введите число: ");
int number =Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine("Квадрат от числа: " + number + " равен " + result);
*/
/*
Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue == Math.Pow(secondValue,2))
{
   Console.WriteLine("Число " + firstValue + " является квадратом от " + secondValue);
}
else
{
    Console.WriteLine("Число " + firstValue + " НЕ является квадратом от " + secondValue);
}
*/

Console.Write("Введите число N: ");
int N =Convert.ToInt32(Console.ReadLine());
if (N<0)
{
    N = N * (-1);
}
int negativeN = N * (-1);
while (negativeN <= N)
{
    Console.WriteLine(negativeN);
    negativeN++;
}
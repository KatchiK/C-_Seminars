 /*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Эта программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if ((99 < number && number < 1000) || (-1000 < number && number < -99))
{
  int secondDigit = Math.Abs((number % 100)/10);
  Console.WriteLine(secondDigit);
}
else
{
  Console.WriteLine("Вы ввели не трёхзначное число!!!");
}
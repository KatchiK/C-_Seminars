/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
string dayWeek;
Console.WriteLine("Эта программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным днём.");
Console.WriteLine("Введите цифру соответствующую дню недели:");
int digitDayWeek = Convert.ToInt32(Console.ReadLine());

while (!(0 < digitDayWeek && digitDayWeek < 8))
{
  Console.WriteLine("Такого дня недели не существует.");
  Console.WriteLine("Введите цифру от 1 до 7:");
  digitDayWeek = Convert.ToInt32(Console.ReadLine());
}
if (digitDayWeek == 1)
{
  dayWeek = "Понедельник";
}
else if (digitDayWeek == 2)
{
  dayWeek = "Вторник";
}
else if (digitDayWeek == 3)
{
  dayWeek = "Cреда";
}
else if (digitDayWeek == 4)
{
  dayWeek = "Четверг";
}
else if (digitDayWeek == 5)
{
  dayWeek = "Пятница";
}
else if (digitDayWeek == 6)
{
  dayWeek = "Суббота";
}
else
{
  dayWeek = "Воскресенье";
}
if (0 < digitDayWeek && digitDayWeek < 6)
{
  Console.WriteLine($"{dayWeek} это рабочий день.");
}
else
{
  Console.WriteLine($"{dayWeek} это выходной день.");
}
/*
14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % 7 && firstNumber % 23)
{
Console.WriteLine("Число кратно 7 и 23");  
}
else
{
  Console.WriteLine("Число одновременн не кратно 7 и 23");
}

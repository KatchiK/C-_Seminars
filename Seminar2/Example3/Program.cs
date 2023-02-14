/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
  Console.WriteLine("Число кратно!");
}
else
{
  Console.WriteLine("Остаток - " + firstNumber%secondNumber);
  Console.WriteLine($"Число {secondNumber} не кратно числу {firstNumber}. остаток равен {firstNumber % secondNumber}");
}
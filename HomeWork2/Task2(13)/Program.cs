/*Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.
78 -> третьей цифры нет
3267900 -> 6
*/
Console.Clear();
Console.WriteLine("Эта программа принимает на вход любое целое число от -2147483647 до 2147483647 и выводит третью цифру слева и справа, если такие присутствуют");

Console.WriteLine("Введите любое целое число:");
int number = Convert.ToInt32(Console.ReadLine());

//Найдём количество разрядов в числе

int numberDigits = 0;
int remainderNumber = number;

while (!(remainderNumber == 0))
{
  remainderNumber = remainderNumber / 10;
  numberDigits++;
}


//Нахождение 3-й цифры

int numberModule = Math.Abs(number);
if (numberDigits > 2)
{
  int rightThirdDigit = (numberModule - (numberModule / 1000) * 1000) / 100;
  
  int leftThirdDigit = (numberModule - (numberModule / (int)Math.Pow(10, (numberDigits - 2))) * (int)Math.Pow(10, (numberDigits - 2))) / (int)Math.Pow(10, (numberDigits - 3));
  
  Console.WriteLine($"В числе {number} третьей цифрой справа является цифра {rightThirdDigit} и третьей цифрой слева является цифра {leftThirdDigit}");
}
else
{
  Console.WriteLine($"В числе {number} третьей цифры нет");
}
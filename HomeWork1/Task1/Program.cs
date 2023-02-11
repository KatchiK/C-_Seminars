/* Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Clear();

Console.WriteLine("Эта программа определяет, какое из введённых Вами двух чисел больше");
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("Число " + firstNumber + " больше, чем число " + secondNumber);
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine("Число " + secondNumber + " больше, чем число " + firstNumber);
}
else
{
    Console.WriteLine("Числa " + secondNumber + " и " + firstNumber + " равны между собой! )))");
}
/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();
int count = 1;
Console.WriteLine("Эта программа определяет, какое из введённых Вами чисел самое большое.");

Console.WriteLine("Укажите сколько чисел будет введено:");
int quantity = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 1-е число: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

while (count < quantity)
{
    count++;
    Console.Write("Введите " + count + "-е число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (maxNumber < number)
    {
        maxNumber = number;
    }
}

Console.WriteLine("Самое большое число, из чисел введённых Вами, это число " + maxNumber + ".");


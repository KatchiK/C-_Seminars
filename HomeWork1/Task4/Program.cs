/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();
Console.WriteLine("Эта программа покажет все чётные числа от 1 до указанного числа.");
Console.WriteLine("Введите число от 2 до ~: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 2;

if (N < 2)
{
    Console.WriteLine("Число " + N + " не принадлежит множеству чисел от 2 до ~.");
}
else
{
    Console.WriteLine("Четные числа от 1 до " + N + ":");
    while (number <= N)
    {
        Console.Write(number + " ");
        number = number + 2;
    }
}


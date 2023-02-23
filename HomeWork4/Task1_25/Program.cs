/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
int EnteringNumber(string text)//Метод для ввода числа, проверки на число "int"
{
    Console.WriteLine(text);
EnterNumber:
    int num = 0;
    bool isNum = int.TryParse(Console.ReadLine(), out num);
    if (isNum == false)
    { 
        Console.WriteLine("Введенное значение не является простым числом. Повторите ввод числе ещё раз:");
        goto EnterNumber;
    }
    return num;
}

int numberA = EnteringNumber("Введите число:");
int numberB = EnteringNumber("Введите степень в которую нужно возвести число:");

int pow = numberA;
if (numberB == 0) pow = 1;
else
{
    for (int i = 1; i < numberB; i++)
    {
        pow = pow * numberA;
    }
}
Console.WriteLine($"Число {numberA} в степени {numberB} будет равно: {pow}");

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

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


int number = EnteringNumber("Введите число:");

int count = number;
int sum = 0;
while (count > 0)
{
    int digit = count % 10;
    sum = sum + digit;
    count = count / 10;

}

Console.WriteLine($"Сумма цифр в числе {number} равняется: {sum}");


/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом (Отрицательное число не может являться палиндромом).
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();

Console.WriteLine("Эта программа принимает на вход пятизначное число и проверяет,является ли оно палиндромом.");
Console.WriteLine("Введите пятизначное число:");

EnterNumber:
var stringNumber = Console.ReadLine();
int number;
bool isNumber = int.TryParse(stringNumber, out number);

//Проверка на правильность ввода 5-значного числа
if (isNumber == false || Math.Abs(number) < 10000 || Math.Abs(number) > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число. Введите еще раз:");
    goto EnterNumber;// Не знаю, на сколько оправданно использование оператора goto, но т.к. через цикл я уже такое делал, то решил попробовать так.
}

//Проверка на палиндромность

int num = number;
int reverseNumber = 0;
while (num > 0)
{
    int dig = num % 10;
    reverseNumber = reverseNumber * 10 + dig;
    num = num / 10;    
}

if (number == reverseNumber)
{
    Console.WriteLine($"Число {stringNumber} является палиндромом.");
}
else
{
    Console.WriteLine($"Увы, число {stringNumber} НЕ является палиндромом.");
}





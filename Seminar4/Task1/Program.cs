// See https://aka.ms/new-console-template for more information
/*
int Calculate(int a, int b) // Два числа: a, b
{
    int result = a + b;
    return result;
}

Console.WriteLine(Calculate(3, 5));
*/

int Calculate(int a, int b, char sign) // Два числа: a, b; 3 параметр: знак(*; /;)
{
    int result = 0;
    // 'для char-a', "двойные кавычки"
    if (sign == '*')
    {
        result = a * b;
    }
    else if (sign == '+')
    {
        result = a + b;
    }
    else if (sign == '-')
    {
        result = a - b;
    }
    else
    {
        Console.WriteLine("Обработка искл. : такого знака нет");
    }
    return result;
}
Console.WriteLine(Calculate(1,2, '+'));
Console.WriteLine(Calculate(3,2, '*'));
Console.WriteLine(Calculate(100,35, '-'));
Console.WriteLine(Calculate(100,35, '_'));
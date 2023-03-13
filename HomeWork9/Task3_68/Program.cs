/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int IntroductionNumbers(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int CalcAckermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return CalcAckermanFunc(m - 1, 1);
    }
    else
    {
        return CalcAckermanFunc(m - 1, CalcAckermanFunc(m, n - 1));
    }

}


int m = IntroductionNumbers("Введите число m:");
int n = IntroductionNumbers("Введите число n:");
Console.WriteLine($"А({m},{n}) = {CalcAckermanFunc(m,n)}");
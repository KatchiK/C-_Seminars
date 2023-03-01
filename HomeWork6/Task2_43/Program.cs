/* Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();

int EnteringNumber(string text)
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

void IntersectionLines(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Координаты пересечения прямых: ({x};{y})");
}

double b1 = EnteringNumber("Введите b1");
double k1 = EnteringNumber("Введите k1");
double b2 = EnteringNumber("Введите b2");
double k2 = EnteringNumber("Введите k2");

IntersectionLines(b1, k1, b2, k2);
/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int IntroductionNumbers(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    
    return num;
}

int SummationNumbers(int startNum, int endNum)
{
    if (startNum == endNum) return endNum;
    return startNum + SummationNumbers(startNum + 1, endNum);
}

int N = IntroductionNumbers("Введите число N:");
int M = IntroductionNumbers("Введите число M:");
Console.WriteLine("Сумма равна - " + SummationNumbers(N, M));

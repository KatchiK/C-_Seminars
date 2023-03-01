/*Задача 42 
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
Console.Clear();
Console.WriteLine("Программа принимает на вход простое десятичное число и преобразовывает его в двоичное.");

int EnteringNumber(string text)//Метод ввода числа, проверки на число "int"
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

int[] ArrayBinNum(int decNum)
{
    int RemainNum = decNum;
    int sizeArray = 0;

    while (RemainNum >= 1)
    {
        RemainNum = RemainNum / 2;
        sizeArray++;
    }
    RemainNum = decNum;
    int[] arrayBinNum = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        arrayBinNum[sizeArray - 1 - i] = RemainNum % 2;
        RemainNum = RemainNum / 2;
    }
    return arrayBinNum;
}

int decNum = EnteringNumber("Введите десятичное число:");
int[] array = ArrayBinNum(decNum);

Console.WriteLine($"Двоичное число:  {String.Join("", array)}");
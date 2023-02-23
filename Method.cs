
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



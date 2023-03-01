
int EnteringNumber(string text)//Метод ввода простого числа, проверки на число "int"
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

int[] GetArray(int size, int minValue, int maxValue) // Создание массива на size элементов
{
    int[] result = new int[size]; // Создание массива на size элементов
    // Если size = 12, то массив состоит из 12 нулей
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result; // Вернули массив на size элементов, заполненный числами
    // от minValue до maxValue
}

Console.WriteLine($"Исходный массив:  [{String.Join("; ", array)}]");//Вывод массива в одну строку.



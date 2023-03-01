// Задача 39: Напишите программу, 
// которая перевернёт одномерный массив (последний элемент 
// будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Задача 39: Напишите программу, 
// которая перевернёт одномерный массив (последний элемент 
// будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// Pascal Case: FillArray, GetArray (методы)
// camelCase: firstNumber
int[] array = FillArray(10, 0, 10); // Массив на 10 элементов,
// заполненный рандомными числами от 0 до 10 включительно
// Console.WriteLine($"Текст:{переменная} текст");
Console.WriteLine($"Исходный массив:  [{String.Join("; ", array)}]");
// FillArray: размер, мин, макс
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
// Запись массива в обратном порядке в новый массив
int[] resultArray = CopyArray(array);
Console.WriteLine("Переворот через не VOID");
Console.WriteLine($"Перевернутый массив:  [{String.Join("; ", resultArray)}]");
int[] CopyArray(int[] inputArray)
{
    int size = inputArray.Length;
    int j = size - 1; // Индекс последнего элемента
    int[] inverseArray = new int[size]; // Массив на size элементов, заполне нулями
    for (int i = 0;  i < size; i++, j--)
    {
        // inverseArray[i] = inputArray[size - 1 - i];
        inverseArray[i] = inputArray[j];
    }
    return inverseArray;
}

// С помощью доп. переменной
void ReverseArray(int[] arr)
{
    // a = {10,20,30,40,50}
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i]; // temp = arr[0] = 10
        arr[i] = arr[arr.Length - 1 - i]; // a[0] = a[5 - 1 - 0] 
        // a = {50,20,30,40,50}
        arr[arr.Length - 1 - i] = temp;
        // a = {50,20,30,40,temp}, a = {50,20,30,40,10}
    }
}
Console.WriteLine("Переворот через метод VOID");
ReverseArray(array); // Здесь массив исходный с именем array перевернулся
Console.WriteLine($"Исходный массив:  [{String.Join("; ", array)}]");
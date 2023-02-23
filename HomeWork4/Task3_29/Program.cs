/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


//Console.Clear();
string? text = Console.ReadLine();
/*
var arrayText = new char[text.Length];
for (int j = 0; j < text.Length; j++)
{
    arrayText[j] = text[j];
}
*/

char[] arrayText = text.ToCharArray();
//Console.WriteLine(text.GetType());

int[] array = new int[8];
int indexArray = 0;
string number = string.Empty;
for (int i = 0; i < arrayText.Length; i++)
{
    int digit;

    bool isDigit = int.TryParse(arrayText[i].ToString(), out digit);
    //digit = Convert.ToInt32(arrayText[i]);
    Console.WriteLine($"digit={digit}");
    if (isDigit == true)
    {
        string textDigit = Convert.ToString(digit);
        number = String.Concat(number, digit);
        Console.WriteLine($"number={number}");
    }

    else
    {
        int intNumber = Convert.ToInt32(number);
        array[indexArray] = intNumber;
        number = string.Empty;
        indexArray++;
    }
    if (isDigit == true || i == arrayText.Length - 1)
    {
        int intNumber = Convert.ToInt32(number);
        array[indexArray] = intNumber;
    }




}

Console.WriteLine($"Массив: [ {String.Join(", ", array)} ]");

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


Console.Clear();
Console.WriteLine("Программа принимает на вход любую строку содержащую до 8 чисел, сохраняет числа в массив, выводит массив в консоль.");
string? text = Console.ReadLine();
char[] arrayText = text.ToCharArray();

int[] array = new int[8];
int indexArray = 0;
string number = "";
for (int i = 0; i < arrayText.Length; i++)
{
    int digit;

    bool isDigit = int.TryParse(arrayText[i].ToString(), out digit);
    if (isDigit == true)
    {
        string textDigit = Convert.ToString(digit);
        number = String.Concat(number, digit);
    }

    else
    {
        int intNumber;
        if ((int.TryParse(number.ToString(), out intNumber)) == true)
        {
            array[indexArray] = intNumber;
            number = "";
            indexArray++;
        }
    }
    if (isDigit == true && i == (arrayText.Length - 1))
    {
        int intNumber = Convert.ToInt32(number);
        array[indexArray] = intNumber;
    }
}

Console.WriteLine($"Массив: [ {String.Join(", ", array)} ]");

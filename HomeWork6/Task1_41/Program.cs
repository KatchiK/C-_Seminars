/*Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

//Console.Clear();
Console.WriteLine("Программа принимает строкой некоторое количество натуральных чисел и выдаёт сколько из введённых чисел было больше 0");
Console.WriteLine("Введите строкой натуральные числа через любой разделитель:");

string? enteredString = Console.ReadLine();

int sizeString = enteredString.Length;
string stringNumber = string.Empty; // переменная, куда будут складываться цифры конкантинацией.
int count = 0; // счетчик чисел > 0

for (int i = 0; i < sizeString; i++)
{
    int digit;// переменная - цифра, которая дальше будет складываться в число.
    bool isDigit = int.TryParse(enteredString[i].ToString(), out digit);// проверка - является ли символ цифрой? Если да, то отправляем цифру в переменную 

    if (isDigit == true || enteredString[i] == '-')// если цифра или "-", то идем к сбору числа
    {
        if (enteredString[i] == '-')//   если "-", то  идем к сбору числа
        {

            if (i == 0 || enteredString[i - 1] != '-')// если предыдущий символ НЕ = "-" или i=0, то записываем "-" в число
            {
                stringNumber = String.Concat(stringNumber, '-');
            }

            else
            {
                stringNumber = string.Empty;
                stringNumber = String.Concat(stringNumber, '-');
            }
        }
        else if (i == sizeString - 1)// Если цифра последний символ в строке
        {
            stringNumber = String.Concat(stringNumber, digit);
            int intNumber = Convert.ToInt32(stringNumber);
            if (intNumber > 0)
            {
                count++;
            }
        }
        else
        {
            stringNumber = String.Concat(stringNumber, digit);
        }
    }


    else//если не цифра и "-", то проверяем, что было перед этим
    {
        if (i != 0)
        {
            if (Char.IsNumber(enteredString, i - 1) == true)//если предыдущий символ цифра, то number преобразуем в число, сравниваем с 0, если нужно, то добавляем счётчик и обнуляем number.

            {
                int intNumber = Convert.ToInt32(stringNumber);
                if (intNumber > 0)
                {
                    count++;

                }
                stringNumber = string.Empty;
            }
        }
    }
}

Console.WriteLine($"Введено {count} числа(сел). больше 0");
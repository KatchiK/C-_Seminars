

Console.WriteLine("Введите число");
bool check = false;
int number = 0;
int count = 0;
while (check == false)
{
    string text = Console.ReadLine();
    if (int.TryParse(text, out number))
    {
        for (int i = 0; i == number - 1; i++)
        {
            number = number / 10;
            count++;
        }
        break;
        check = true;
    }
    else
    {
        Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
    }
}
Console.WriteLine(count);
// See https://aka.ms/new-console-template for more information

int number = new Random().Next(10, 100);
int firstValue = number/10;
int secondValue = number%10;
int max = firstValue;
if (max < secondValue)
{
  max = secondValue;
}
Console.WriteLine("Максимальная цифра в числе " + number + " это" + max);
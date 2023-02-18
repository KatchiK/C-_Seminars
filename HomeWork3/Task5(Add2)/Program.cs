/*Доп. задание №2:
Назовем число интересным, если в нем разность максимальной и минимальной цифры 
равняется средней по величине цифре. Напишите программу, 
которая определяет интересное число или нет. 
Если число интересное, следует вывести – «Число интересное» иначе «Число неинтересное».
-> 945 - число интересное, средняя цифра - 4, разница: 9 - 5 = 4
*/

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");


EnterNumber:
var stringNumber = Console.ReadLine();
int number;
bool isN = int.TryParse(stringNumber, out number);

if (isN == false || number < 100 || number > 999)
{
    Console.WriteLine($"Введённое значение \"{stringNumber}\" не является 3х значным числом.\nВведите сумму вклада ещё раз:");
    goto EnterNumber;
}

int d1 = number/100;
int d2 = (number%100)/10;
int d3 = number%10;

if (d2 == Math.Abs(d1-d3))
{
    Console.WriteLine($"Число {number} ну очень интересное число!!!");
}
else
{
     Console.WriteLine($"Число {number} совсем не интересное число");
}


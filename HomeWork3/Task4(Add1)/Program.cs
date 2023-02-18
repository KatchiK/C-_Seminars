/*Доп. задание №1:
Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. 
На вход будет подаваться число (сумма вклада). При значении меньше 100, 
будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %, 
если больше — 10 %. Отработав, программа должна вывести общую сумму с начисленными процентами.
*/
Console.Clear();
Console.WriteLine("Введите сумму вклада: ");


EnterNumber:
var stringDepositAmount = Console.ReadLine();
double depositAmount;
bool isN = double.TryParse(stringDepositAmount, out depositAmount);

if (isN == false || depositAmount < 1)
{
    Console.WriteLine($"Введённое значение \"{stringDepositAmount}\" не может являться вкладом.\nВведите сумму вклада ещё раз:");
    goto EnterNumber;
}

int per;
if (depositAmount < 100)
{
    per = 5;
}
else if (depositAmount < 201)
{
    per = 7;
}
else
{
    per = 10;
}

Console.WriteLine(per);
Console.WriteLine(depositAmount);
double sum = (depositAmount / 100) * per + depositAmount;
Console.WriteLine($"При вкладе {depositAmount} сумма с процентами будет составлять: {sum}");
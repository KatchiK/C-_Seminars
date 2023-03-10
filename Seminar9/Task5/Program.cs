Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печатаем все натуральные числа в промежутке от 1 до N.
/// </summary>
/// <param name="start"> 1 = start</param>
/// <param name="end"> N = end</param>
/// <returns></returns>
string PrintNumbers(int start, int end)
{
    // Базовый
    if (start == end) return start.ToString();
    // Рекурсивный
    return (start + ", " + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(1, N));
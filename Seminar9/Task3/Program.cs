﻿//Нахождение факториала через рекурсию.

int Factorial(int n)
{
    // Базовый случай - случай выхода из рекурсии
    if (n == 1) return 1; // Факториал от 1 = 1
    // Рекурсивный случай - задание рекурсии (вызов функции внутри функции)
    return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(4)); // 4*3*2*1 = 24
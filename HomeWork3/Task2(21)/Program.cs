/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координату точки A по оси X:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки A по оси У:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А по оси Z:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси X:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси У:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси Z:");
int z2 = Convert.ToInt32(Console.ReadLine());


var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 -z1, 2));

//Console.WriteLine(Math.Round(Math.Abs(result), 2));
Console.WriteLine(Math.Round(result, 2));
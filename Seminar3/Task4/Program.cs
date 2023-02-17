/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координату точки A по оси X:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки A по оси У:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси X:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси У:");
int y2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2));

//Console.WriteLine(Math.Round(Math.Abs(result), 2));
Console.WriteLine(Math.Round(result, 2));


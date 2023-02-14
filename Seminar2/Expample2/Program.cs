// See https://aka.ms/new-console-template for more information
int number = new Random().Next(100, 1000);
int result = (number/100)*10 + number%10;
Console.WriteLine("Исходное число " + number + "; 1 и 3 цифры - " + result);

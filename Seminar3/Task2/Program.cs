// Вводится строчка. Делаем проверку - все ли символы являются цифрами

Console.WriteLine("Hello, World!");

var stringNumber = "1234asdf";
int number; //Если строчка состоит из чисел, то сюда попадает наше число
bool isNumber = int.TryParse(stringNumber, out number); //True - строчка состоит из чисел.

Console.WriteLine(isNumber);
Console.WriteLine(number);

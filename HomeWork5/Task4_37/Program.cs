


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size]; // Создание массива на size элементов
    // Если size = 12, то массив состоит из 12 нулей
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result; // Вернули массив на size элементов, заполненный числами
    // от minValue до maxValue
}

int[] ArrayProduct(int[] arr)
{
    int sizeArr = arr.Length;
    int sizeArrProd = sizeArr / 2 + sizeArr % 2;
    int[] arrProd = new int[sizeArrProd];
    for (int i = 0; i < sizeArrProd; i++)
    {
        if (i == sizeArr -1 - i)
        {
            arrProd[i] = arr[i];
        }
        else
        {
            arrProd[i] = arr[i] * arr[sizeArr - 1 - i];

        }


    }
    return arrProd;

}
int[] array = GetArray(11, -10, 10);
int[] arrayProduct = ArrayProduct(array);

Console.WriteLine($"Исходный массив:\n[{String.Join("; ", array)}]");
Console.WriteLine($"Полученный массив:\n[{String.Join("; ", arrayProduct)}]");

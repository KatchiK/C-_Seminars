

int rows = 3;

int cols = 3;

int[,] matrix = new int[rows, cols];

int min = int.MaxValue;

int indexMinRows = 0; // Номер строчки с мин. элементом
int indexMinCols = 0; // Номер строчки с мин. элементом

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i,j] = new Random().Next(11); // 0-10
        Console.Write(matrix[i,j] + "\t");
        if (min > matrix[i,j])
        {
            min = matrix[i,j];
            indexMinRows = i;
            indexMinCols = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Мин.элемент: {min}, \t строчка: {indexMinRows}, \t cтолб: {indexMinCols}");

for (int i = 0; i < rows; i++)
{
    if(i != indexMinRows)
    {
        for (int j = 0; j < cols; j++)
        {
            if (j != indexMinCols)
            {
                Console.Write(matrix[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
}
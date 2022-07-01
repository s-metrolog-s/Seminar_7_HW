// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 5 3
// 8 4 6 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.

Random rand = new Random();
int m = rand.Next(1, 10);
int n = rand.Next(1, 10);
int[,] matrix = new int[m, n];

Console.Clear();
Console.WriteLine($"*************************************************");
Console.WriteLine($"Дан массив на {m} строк (-и) и {n} столбца (-ов)");
Console.WriteLine($"*************************************************");

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine($"*************************************************");
Console.WriteLine($"Найдем среднее арифметическое для каждого столбца");
Console.WriteLine($"*************************************************");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    AvrNumberColumn(matrix, j);
}
Console.WriteLine($"*************************************************");

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void AvrNumberColumn (int[,] array, int column)
{
    double sum = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        sum = sum + array[i, column];
        count++;
    }
    double result = sum/count;
    // Ввожу "+ 1" для удобства чтения пользователю
    Console.WriteLine($"Ср. арифм. {column + 1} столбца -> {Math.Round(result, 2)}");
}
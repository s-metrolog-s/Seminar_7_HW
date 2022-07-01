// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Random rand = new Random();
int m = rand.Next(2, 10);
int n = rand.Next(2, 10);

double[,] matrix = new double[m, n];
Console.Clear();
Console.WriteLine($"**************************************");
Console.WriteLine($"Дан массив на {m} строк и {n} столбцов");
Console.WriteLine($"**************************************");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine($"**************************************");

void FillArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.NextDouble() + rand.Next(-9, 10), 1);
        }
    }
}

void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
            Thread.Sleep(300); // Добавил, чтобы посмотреть как именно заполняется массив
        }
        Console.WriteLine();
    }
}
// Задача 50: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 3] -> 3

Random rand = new Random();
int m = rand.Next(2, 10);
int n = rand.Next(2, 10);
double[,] matrix = new double[m, n];

Console.Clear();
Console.WriteLine($"*************************************************");
Console.WriteLine($"Дан массив на {m} строк (-и) и {n} столбца (-ов)");
Console.WriteLine($"*************************************************");

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine($"*************************************************");
Console.WriteLine("Введите позицию элемента в строке:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец позиции элемента:");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"*************************************************");
Console.WriteLine("Поиск элемента...");

CheckElement(matrix, row, column);
Console.WriteLine($"*************************************************");

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
        }
        Console.WriteLine();
    }
}

void CheckElement (double[,] array, int row, int column)
{
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            if (i == row - 1 && j == column - 1)
            {
                // Ввожу "- 1" для удобства отражения пользователю для счета с 1, а не с 0
                Console.WriteLine($"Значение элемента [{row}:{column}] = {array[i, j]}");
                flag = true;
            }
        }
    }
    if (!flag) Console.WriteLine($"Значение элемента [{row}:{column}] отсуствует");
}
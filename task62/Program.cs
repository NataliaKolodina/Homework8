// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, colums, 1, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    int i = 0;
    for (int j = 0; j < n; j++)
    {
        result[i, j] = new Random().Next(minValue, maxValue);
    }
    int j = n;
    for (int i = 1; i < m; i++)
    {
        result[i, j] = new Random().Next(minValue, maxValue);
    }
    i = m;
    for (int j = n - 1; j >= 0; j--)
    {
        result[i, j] = new Random().Next(minValue, maxValue);
    }
    j = 0;
    for (int i = m - 1; i > 0; i--)
    {
        result[i, j] = new Random().Next(minValue, maxValue);
    }
    i = 1;
    for (int j = 1; j < m - 1; j++)
    {
        result[i, j] = new Random().Next(minValue, maxValue);
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

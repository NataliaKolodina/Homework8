// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Введите количество строк первой матрицы: ");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массивов: ");
int colums = int.Parse(Console.ReadLine()!)!;

int[,] array1 = GetArray(rows, colums, 0, 10);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(colums, rows, 0, 10);
PrintArray(array2);
Console.WriteLine();
int[,] arrayRes = MatrixMultiplication(array1, array2);
PrintArray(arrayRes);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
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

int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
{
    int[,] res = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(0); k++)
            {
                int a = (arr1[i, k] * arr2[k, j]);
                sum = sum + a;
            }
            res[i, j] = sum;
        }
    }
    return res;
}

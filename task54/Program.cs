﻿// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, colums, 1, 10);
PrintArray(array);
Console.WriteLine();
MinMaxArray(array);

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

void MinMaxArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int max = arr[i, 0];
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > max)
            {
                int temp = arr[i, j];
                arr[i, j] = max;
                max = temp;
                max = arr[i, j];
                Console.Write($"{max} ");
            }
            else
            {
                Console.Write($"{arr[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
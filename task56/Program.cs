// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, colums, 1, 3);
PrintArray(array);
Console.WriteLine();
int[] array1 = SumElemRows(array);
MinSum(array1);

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

int[] SumElemRows(int[,] arr)
{
    int[] result = new int[rows];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        result[i] = sum;
        // Console.Write($"{sum} "); // если нужно вывести на экран массив, состоящий из сумм - для проверки
    }
    return result;
}

void MinSum(int[] NewArray)
{
    int minindex = 0;
    int min = NewArray[minindex];

    for (int i = 1; i < NewArray.Length; i++)
    {
        if (NewArray[i] < min)
        {
            min = NewArray[i];
            minindex = i;
        }
    }
    for (int i = minindex + 1; i < NewArray.Length; i++) // ищем, есть ли еще строка с минимальной суммой элементов, и выводим также ее в результат
    {
        if (NewArray[i] == min)
        {
            Console.WriteLine($"наименьшая сумма элементов у строки № {i + 1}");
        }
    }
    Console.WriteLine($"наименьшая сумма элементов у строки № {minindex + 1}");
}

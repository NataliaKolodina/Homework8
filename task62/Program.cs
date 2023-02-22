// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

const int cellWidth = 2;
int[,] array = GetArray();
PrintArray(array);

int[,] GetArray()
{
    int num = 01;
    int[,] result = new int[4, 4];
    int i = 0;
    int j = 0;
    for (j = 0; j < 4; j++)
    {
        result[i, j] = num;
        num++;
    }
    j = 3;
    for (i = 1; i < 4; i++)
    {
        result[i, j] = num;
        num++;
    }
    i = 3;
    for (j = 2; j >= 0; j--)
    {
        result[i, j] = num;
        num++;
    }
    j = 0;
    for (i = 2; i > 0; i--)
    {
        result[i, j] = num;
        num++;
    }
    i = 1;
    for (j = 1; j < 3; j++)
    {
        result[i, j] = num;
        num++;
    }
    j = 2;

    for (i = 2; i < 3; i++)
    {
        result[i, j] = num;
        num++;
    }
    i = 2;
    for (j = 1; j > 0; j--)
    {
        result[i, j] = num;
        num++;
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j], cellWidth} ");
        }
        Console.WriteLine();
    }
}

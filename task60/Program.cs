// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();

int r = InputNum("Введите количество строк матрицы: ");
int c = InputNum("Введите количество столбцов матриыц: ");
int z = InputNum("Введите количество элементов третьей плоскости матрицы: ");

int[,,] array = GetArray(r, c, z, 10, 100);
PrintArray(array);

int InputNum(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

int[,,] GetArray(int m, int n, int k, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                result[i, j, l] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int l = 0; l < inArray.GetLength(2); l++)
            {
                Console.Write($"{inArray[i, j, l]} ({i}, {j}, {l})");
            }
        }
        Console.WriteLine();
    }
}

// Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.

int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetMinRowNumber(int[,] array)
{
    int row = 1;
    int minSum =0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            row = i + 1;
        }
    }
    return row;
}

int[,] myArray = GetArray(rows, columns, 0, 9);
PrintArray(myArray);
Console.WriteLine();
int minRow = GetMinRowNumber(myArray);
Console.WriteLine(minRow);
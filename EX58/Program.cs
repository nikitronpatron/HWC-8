// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] GetMultiplicationArrays(int[,] frstArr, int[,] scndArr)
{
    int[,] multiplicationArr = new int[frstArr.GetLength(0), frstArr.GetLength(1)];
    for (int i = 0; i < frstArr.GetLength(0); i++)
    {
        for (int j = 0; j < frstArr.GetLength(1); j++)
        {
            for (int temp = 0; temp < frstArr.GetLength(1); temp++)
            {
                multiplicationArr[i, j] += frstArr[i, temp] * scndArr[temp, j];
            }
        }
    }
    return multiplicationArr;
}

int[,] firstArray = GetArray(rows, columns, 0, 9);
PrintArray(firstArray);
Console.WriteLine();
int[,] secondArray = GetArray(rows, columns, 0, 9);
PrintArray(secondArray);
Console.WriteLine();
int[,] thirdArray = GetMultiplicationArrays(firstArray, secondArray);
PrintArray(thirdArray);
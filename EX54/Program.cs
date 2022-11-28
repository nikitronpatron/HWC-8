// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива

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

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int temporary = 0; temporary < array.GetLength(1); temporary++)
            {
                if(array[i, temporary] < array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, temporary];
                    array[i, temporary] = temp;
                }
            }
        }
    }
}

int[,] myArray = GetArray(rows, columns, 0, 9);
PrintArray(myArray);
Console.WriteLine();
SortArray(myArray);
PrintArray(myArray);
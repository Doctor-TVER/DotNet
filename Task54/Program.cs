// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// печать двумерного массива
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// универсальный метод генерации и заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int start, int stop)
{
    int[,] arr2D = new int[countRow, countColumn];
    Random ren = new Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr2D[i, j] = ren.Next(start, stop + 1);
        }
    }
    return arr2D;
}

int[,] UpdateArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        List<int> Row = new List<int>();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Row.Add(arr[i,j]);
            Row.Sort();
            Row.Reverse();
        }
        for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i,j]=Row[j];
            }
    }
    return arr;
}

int[,] arr = Fill2DArray(4,4,0,9);
Print2DArray(arr);
Console.WriteLine();
UpdateArray(arr);
Print2DArray(arr);
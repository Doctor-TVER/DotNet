// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Fill2DArray(int countRow, int countColumn, int start, int stop)
{
    int[,] arr2D = new int[countRow, countColumn];
    Random ren = new Random();
    // тест границ
    int x = 0;
    if (stop < start)
    {
        x = stop;
        stop = start;
        start = x;
    }
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr2D[i, j] = ren.Next(start, stop + 1);
        }

    }
    return arr2D;
}

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

void PrintArray(double[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

double[] Count(int[,] arr2D)
{
    double[] arr = new double[arr2D.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr[j] = arr[j] + arr2D[i, j];
        }
    }  
    for (int k = 0; k < arr2D.GetLength(1); k++)
    {
        arr[k] = arr[k] / (double)arr2D.GetLength(0);
    }
    return arr;
}

int[,] arr2D = Fill2DArray(4, 4, 1, 10);
Print2DArray(arr2D);
double[] arr = Count(arr2D);
PrintArray(arr);
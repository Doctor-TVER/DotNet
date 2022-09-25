// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
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

int FindMinRow(int[,] arr)
{
    int min = int.MaxValue;
    int sum = 0;
    int outIndexRow = -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (min > sum)
        {
            min = sum;
            outIndexRow = i;
        }
    }
    return outIndexRow;
}

int[,] arr = Fill2DArray(4,4,0,9);
Print2DArray(arr);
Console.WriteLine();
PrintResult("Индекс строки с наименьшей суммой элементов: ", FindMinRow(arr));

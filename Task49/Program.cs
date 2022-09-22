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
                arr2D[i,j] = ren.Next(start, stop+1);
            }
        }
    return arr2D;
}

int[,] Update2DArr(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr2D.GetLength(1); j = j + 2)
        {
            arr2D[i, j] = arr2D[i, j] * arr2D[i, j];
        }
    }
    return arr2D;
}

int[,] arr2D = Fill2DArray(5,5,1,20);
Print2DArray(arr2D);
Console.WriteLine();
Console.WriteLine();
Print2DArray(Update2DArr(arr2D));
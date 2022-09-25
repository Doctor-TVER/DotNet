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

void MinFind(int[,] arr, ref int x, ref int y)
{
    int min = arr[0, 0];
    x = 0; y = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                x = i;
                y = j;
            }               
        }
    }
}

int[,] CreateArray(int[,] arr, int x, int y)
{
    int k = 0; int m = 0;
    int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == x)
        {
        }
        else
        {
            m = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j == y)
                {
                }
                else
                {
                    outArr[k, m] = arr[i, j];
                    m++;
                }
            }
            k++;
        }

    }
    return outArr;
}

int[,] arr2D = Fill2DArray(4, 4, 0, 9);
Print2DArray(arr2D);
int x = -1;
int y = -1;
MinFind(arr2D, ref x, ref y);
int[,] outArr = CreateArray(arr2D, x, y);
Print2DArray(outArr);
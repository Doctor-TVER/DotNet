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
int[,] Fill2DArrMN(int m, int n)
{
    int[,] arr2D = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr2D[i, j] = i + j;
        }
    }
    return arr2D;
}

Print2DArray(Fill2DArrMN(6, 7));


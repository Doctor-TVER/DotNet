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

void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
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

int DiagSum(int[,] arr2D)
{
    int sum = 0;
    int len = arr2D.GetLength(0) > arr2D.GetLength(1) ? arr2D.GetLength(1) : arr2D.GetLength(0);
    for (int i = 0; i < len; i++)
    {
        sum = sum + arr2D[i,i];
    }
    return sum;
}

int[,] arr2D = Fill2DArray(3,4,1,10);
Print2DArray(arr2D);

PrintResult("Сумма чисел по диагонали",DiagSum(arr2D));

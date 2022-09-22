// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// универсальный метод генерации и заполнения двумерного массива
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

int FindElem(int x, int y, int[,] arr2D)
{
    if (x < arr2D.GetLength(0) && y < arr2D.GetLength(1))
    {
        return arr2D[x, y];
    }
    else
    {
        return -1;
    }
}

void Print(int a)
{
    if (a == -1)
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine(a);
    }
}

int[,] arr2D = Fill2DArray(3, 4, 1, 5);
Print2DArray(arr2D);

Print(FindElem(0, 0, arr2D));
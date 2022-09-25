int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
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
void Fill2DArray(int[,] arr, int start, int stop)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(start, stop + 1);
        }
    }
}

bool TestRotate(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] RotateArray(int[,] arr)
{
    int buf = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            buf = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = buf;
        }
    }
    return arr;
}

int m = ReadData("Введите количество строк m: ");
int n = ReadData("Введите количество столбцов n: ");
int[,] arr = new int[m, n];

Fill2DArray(arr, 1, 9);
Print2DArray(arr);
Console.WriteLine();

if (TestRotate(arr))
{
    int[,] arrRotate = RotateArray(arr);
    Print2DArray(arrRotate);
}
else
{
    Console.WriteLine("Матрицу нельзя транспонировать!");
}
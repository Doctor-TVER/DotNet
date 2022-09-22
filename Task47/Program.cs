// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// универсальный метод генерации и заполнения двумерного массива
double[,] Fill2DArray(int countRow, int countColumn)
{
    double[,] arr2D = new double[countRow, countColumn];
    Random ren = new Random();
  
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr2D[i, j] = ren.NextDouble();
        }

    }
    return arr2D;
}

// печать двумерного массива
void Print2DArray(double[,] arr)
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

int m = ReadData("Строки: ");
int n = ReadData("Столбцы: ");

double[,] arr2D = Fill2DArray(m, n);
Print2DArray(arr2D);
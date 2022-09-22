int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
}

// универсальный метод генерации и заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int start,int stop)
{
    int[,] arr2D = new int[countRow, countColumn];
    Random ren = new Random();
// тест границ
    int x = 0;
    if(stop<start)
    {
        x= stop;
        stop = start;
        start = x;
    }
    for (int i = 0; i < countRow; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                arr2D[i,j] = ren.Next(start, stop+1);
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
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

// массив цветов
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue, ConsoleColor.DarkBlue, 
                                        ConsoleColor.DarkGreen};

// печать двумерного массива цветом
void Print2DArrayColor(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,3)];
            Console.Write($"{arr[i,j]}\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Строки: ");
int column = ReadData("Столбцы: ");

int[,] arr2D = Fill2DArray(row, column, 1, 100);
Print2DArrayColor(arr2D);

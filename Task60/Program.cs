// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// печать трехмерного массива с индексами элементов
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
            Console.Write($"{arr[i, j, k]} i={i} y={j} k={k}\t");
            }
            Console.WriteLine();
        }
    }
}

// универсальный метод генерации и заполнения трехмерного массива
int[,,] Fill3DArray(int countRow, int countColumn, int countHeight, int start, int stop)
{
    int[,,] arr3D = new int[countRow, countColumn, countHeight];
    Random ren = new Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int k = 0; k < countHeight; k++)
            {
            arr3D[i, j, k] = ren.Next(start, stop + 1);
            }
        }
    }
    return arr3D;
}

Print3DArray(Fill3DArray(3,3,3,1,9));
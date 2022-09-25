// создание и заполнение частотного массива

// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
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

// печать одномерного массива
void PrintArray(int[] arr)
{
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}
// частотный словарь двумерного массива с заранее заданными ключами
// int[] FreqDicLoad(int[,] arr)
// {
//     int[] dic = new int[10]; // создаем частотный словарь
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             dic[arr[i, j]]++; // заполняем частотный словарь
//         }
//         return dic;
//     }
// }

// возврат частотного словаря элементов двумерного массива
SortedDictionary<int, int> CountDictionary(int[,] arr)
{
    SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (dict.ContainsKey(arr[j, i]))
                dict[arr[j, i]]++;
            else
                dict.Add(arr[j, i], 1);
        }
    }
    return dict;
}

int[,] arr = Fill2DArray(5, 5, 1, 9);
Console.WriteLine("\n---------------------Исходная матрица---------------------\n");
Print2DArray(arr);

SortedDictionary<int, int> dict = CountDictionary(arr);

PrintAnswer("Сколько повторений\n", "Число");
foreach (KeyValuePair<int, int> kvp in dict)
{
    PrintAnswer(kvp.Value.ToString(), kvp.Key.ToString());
}
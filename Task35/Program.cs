// универс метод генерации и заполнения массива
int[] FillArray(int arrayLen,int start,int stop)
{
    int[] array = new int[arrayLen];
    Random ren = new Random();
// тест границ
    if(stop>start)
    {
        for (int i = 0; i < arrayLen; i++)
        {
            array[i] = ren.Next(start, stop+1);
        }
    }
    return array;
}

// печать одномерного массива
void PrintArray(int[] array)
{
    // for (int i = 0; i < array.Length - 1; i++)
    // {
    //     Console.Write(array[i] + ", ");
    // }
    // Console.WriteLine(array[array.Length - 1]);
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

// поиск числа
int CountElem(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(Test(arr[i]))
        {
            count++;
        }
    }
    return count;
}

bool Test(int a)
{
    return (a>10 && a<99);
}

int[] Array = FillArray(123,1, 1000);
PrintArray(Array);

PrintResult("В массиве " + CountElem(Array) + "элементов В отрезке [10,99]");

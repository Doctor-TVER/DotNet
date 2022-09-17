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

void PrintResult(bool answer)
{
    Console.WriteLine(answer ? "Да" : "Нет");
}

// поиск числа
bool FindElem(int[] arr,int elm)
{
    bool res = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]==elm)
        {
            // res = true;
            // brake;
            return true;
        }
    }
    return res;
}

int[] inputArray = FillArray(10,-5, 5);
PrintArray(inputArray);

PrintResult(FindElem(inputArray, 3));

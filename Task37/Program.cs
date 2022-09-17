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


// поиск числа
int[] Change(int[] arr)
{
    int[] outArr = new int[arr.Length/2]; 
    for (int i = 0; i < arr.Length/2; i++)
    {
        outArr[i]=arr[i]*arr[arr.Length-1-i];
    }
    return outArr;
}

int[] array = FillArray(50,1, 1000);
PrintArray(array);

PrintArray(Change(array));

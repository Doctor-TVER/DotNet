// Разворот массива

int[] FillArray(int arrayLen,int start,int stop)
{
    int[] arr = new int[arrayLen];
    Random ren = new Random();
// тест границ
    int x = 0;
    if(stop<start)
    {
        x= stop;
        stop = start;
        start = x;
    }
    for (int i = 0; i < arrayLen; i++)
        {
            arr[i] = ren.Next(start, stop+1);
        }
    return arr;
}

// печать одномерного массива
void PrintArray(int[] arr)
{
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}

// метод разворота массива и создания нового
int[] SwapNewArray(int[] arr)
{
    int[] outarr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outarr[i] = arr[arr.Length-1-i];
    }
    return outarr;
}

// метод разворота массива
int[] SwapArray(int[] arr)
{
    int bufElem = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        bufElem = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = arr[i];
        arr[i] = bufElem;
    }
    return arr;
}

int[] arr = FillArray(20,1,100);
Console.WriteLine("Исходный массив");
PrintArray(arr);
int[] copyArr = SwapNewArray(arr);
Console.WriteLine("Новый перевернутый массив");
PrintArray(copyArr);
Console.WriteLine("Исходный массив");
PrintArray(arr);
arr = SwapArray(arr);
Console.WriteLine("Новый перевернутый массив");
PrintArray(arr);

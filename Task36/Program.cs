// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int OddSumPos(int[] arr)
{
    int a = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        a+=arr[i];
    }
    return a;
}

int[] arr = FillArray(10,10,-10);
PrintArray(arr);
PrintResult("Сумма элементов, стоящих на нечётных позициях: " + OddSumPos(arr));

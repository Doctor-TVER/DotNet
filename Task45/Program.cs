﻿int[] FillArray(int arrayLen,int start,int stop)
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

int[] CopyArr(int[] arr)
{
    int[] outarr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outarr[i]=arr[i];
    }
    return outarr;
}

int[] arr = FillArray(10,-5,5);
PrintArray(CopyArr(arr));
PrintArray((int[])arr.Clone());
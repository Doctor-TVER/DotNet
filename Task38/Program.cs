// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double[] FillArray(int arrayLen)
{
    double[] arr = new double[arrayLen];
    Random ren = new Random();
      
    for (int i = 0; i < arrayLen; i++)
    {
        arr[i] = ren.NextDouble();
    }
    
    return arr;
}

// печать одномерного массива
void PrintArray(double[] arr)
{
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

double[] InsertSort(double[] arr)
{
    for(int i=1; i < arr.Length; i++)
    {
        double k = arr[i];
        int j = i - 1;

        while(j>=0 && arr[j] > k)
        {
            arr[j + 1] = arr[j];
            arr[j] = k;
            j--;
        }
    }
    return arr;
}

double MaxMin(double[] arr)
{
    // double max = int.MinValue;
    // double min = int.MaxValue;
    // for (int i = 0; i < arr.Length; i++)
    // { 
    //     if(arr[i]>max) max = arr[i];
    //     if(arr[i]<min) min = arr[i];
    // }
    return(arr[arr.Length-1]-arr[0]);
}

double[] arr = FillArray(10);
PrintArray(arr);
InsertSort(arr);
PrintArray(arr);
PrintResult("Разница между максимальным и минимальным элементов массива: " + MaxMin(arr));

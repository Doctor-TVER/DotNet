// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

int[] FillArray(int arrayLen,int start=100,int stop=999)
{
    int[] arr = new int[arrayLen];
    Random ren = new Random();
// тест границ
    if(stop>start)
    {
        for (int i = 0; i < arrayLen; i++)
        {
            arr[i] = ren.Next(start, stop+1);
        }
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

int[] BubleSort(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] > arr[j + 1]) 
            {
                temp = arr[j + 1];
                arr[j + 1] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}

int EvenCount(int[] arr)
{
    int a = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(EvenTest(arr[i]))
        {
            a++;
        }
    }
    return a;
}

bool EvenTest(int a)
{
    return(a%2==0);
}

int[] arr = FillArray(10);
PrintArray(arr);
PrintArray(BubleSort(arr));
PrintResult("Количество четных чисел в массиве: " + EvenCount(arr));


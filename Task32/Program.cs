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
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

// инверсия массива
int[] InverseArray(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= arr[i]*(-1);
    }
    return arr;
}

int[] inputArray = FillArray(10,-5, 5);
PrintArray(inputArray);
int[] sumArray = InverseArray(inputArray);

PrintArray(sumArray);

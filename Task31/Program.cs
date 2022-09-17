int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

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

void PrintResult(string line)
{
    Console.WriteLine(line);
}

// вычисление суммы
int[] NegativPositivSums(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
        {
            sums[0]+=arr[i];
        }
        else
        {
            sums[1]+=arr[i];
        }
    }
    return sums;
}

int arrayLen = ReadData("Введите длину массива");
int start = ReadData("Введите нижнюю границу заполнения массива");
int stop = ReadData("Введите верхнюю границу заполнения массива");

int[] inputArray = FillArray(arrayLen,start, stop);
PrintArray(inputArray);
int[] sumArray = NegativPositivSums(inputArray);

PrintResult("Сумма>0: "+sumArray[0]+ "Сумма<0: "+sumArray[1]);
PrintArray(sumArray);
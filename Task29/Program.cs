// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[] GenArray(int arrayLen,int start,int stop)
{
    int[] array = new int[arrayLen];
    Random ren = new Random();
    for (int i = 0; i < arrayLen; i++)
    {
        array[i] = ren.Next(start, stop);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

PrintArray(GenArray(ReadData("Введите длину массива "),ReadData("Число от "),ReadData("Число до ")));

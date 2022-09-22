// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// печать одномерного массива
void PrintArray(double[] arr)
{
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}

double[] PointFind(double b1, double b2, double k1, double k2)
{
    double[] outarr = new double[2];
    outarr[0] = (b2 - b1)/(k1 - k2);
    outarr[1] = k1 * (b2 - b1)/(k1 - k2) + b1;
    return outarr;
}

PrintArray(PointFind(ReadData("Введите число b1: "), ReadData("Введите число b2: "), 
           ReadData("Введите число k1: "), ReadData("Введите число k2: ")));
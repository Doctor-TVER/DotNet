// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(int line)
{
    Console.WriteLine(line);
}

int RecSumMN(int m, int n)
{
    return m >= n ? n : m + RecSumMN(m + 1, n);
}

int m = ReadData("Введите Число m: ");
int n = ReadData("Введите Число n: ");

PrintResult(m < n ? RecSumMN(m, n) : RecSumMN(n, m));


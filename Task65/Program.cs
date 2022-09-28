// Задайте значения M и N. Напишите программу, которая выведет натуральных элементов в промежутке от M до N.

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

string RecMN(int m, int n)
{
    if(m >= n) return n + "";
    
    return m + " " + RecMN(m + 1, n);
}

int m = ReadData("Введите Число m: ");
int n = ReadData("Введите Число n: ");
string outline = m < n ? RecMN(m, n) : RecMN(n, m);
PrintResult(outline);

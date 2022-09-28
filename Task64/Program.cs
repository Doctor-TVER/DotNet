//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии);

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

string LineGenRec(int numN)
{
    if (numN == 0) return ""; // точка остановки
    string outline = numN + " " + LineGenRec(numN - 1);
    return outline;
}

int numN = ReadData("Число: ");
string resultLine = LineGenRec(numN);
PrintResult(resultLine);
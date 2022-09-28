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
    if (numN == 0) return "";
    string outline = LineGenRec(numN - 1) + " " + numN;
    return outline;
}

int numN = ReadData("Число: ");
string resultLine = LineGenRec(numN);
PrintResult(resultLine);

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// 
string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outline = string.Empty;
    while (i < numberN)
    {
        outline = outline + Math.Pow(i, pow) + "\t";
        i++;
    }
    outline = outline + Math.Pow(numberN, pow);
    return outline;
}


void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N ");

PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 2));


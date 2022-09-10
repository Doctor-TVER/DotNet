int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double Calc(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите x1 ");
int x2 = ReadData("Введите x2 ");
int y1 = ReadData("Введите y1 ");
int y2 = ReadData("Введите y2 ");

PrintResult(Math.Round(Calc(x1, x2, y1, y2),2).ToString());

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

int RecSumDig(int num)
{
    return num==0 ? 0 : num % 10 + RecSumDig(num / 10);
}

PrintResult(RecSumDig(ReadData("Введите Число: ")));


int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

string FibNum(int num)
{
    string res = "";
    int first = 0;
    int last = 1;
    int buf = 0;
    for (int i = 0; i < num; i++)
    {
        res = res + " " + first;
        buf = first + last;
        first = last;
        last = buf;
    }
    return res;
}

int a = ReadData("Введите количество чисел Фибоначчи: ");
PrintResult("Числа Фибоначчи: ", FibNum(a));

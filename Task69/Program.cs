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

int RecPow(int a, int b)
{
    return b==1 ? a : a * RecPow(a, b - 1);
}

int Poww(int A,int B)
{
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res = res *A;
    }
    return res;
}

PrintResult(RecPow(ReadData("Введите Число a: "), ReadData("Введите Число b: ")));
PrintResult(Poww(ReadData("Введите Число a: "), ReadData("Введите Число b: ")));

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

string BinConvert(int a)
{
    string res = String.Empty;
    while(a>0)
    {
        res = a % 2 + res;
        a = a / 2;
    }
    return res;
}

int a = ReadData("Введите число а: ");
PrintResult("Исходное число в бинарном формате: ", BinConvert(a));
string n = Convert.ToString(a, 2);
PrintResult("Исходное число в бинарном формате: ", n);
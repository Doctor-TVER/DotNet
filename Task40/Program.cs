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

bool TrglTest(int a, int b, int c)
{
    // bool res = False;
    // if((a+b>c) && (a+c>b) && (c+b>a))
    // {
    //     res = True;
    // }
    // return res;
    return((a+b>c) && (a+c>b) && (c+b>a));
}

int a = ReadData("Введите длину стороны а: ");
int b = ReadData("Введите длину стороны b: ");
int c = ReadData("Введите длину стороны c: ");
PrintResult(TrglTest(a, b, c) ? "Такой треугольник может быть" : "Такого треугольника не может быть");
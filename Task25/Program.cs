// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(long line)
{
    Console.WriteLine(line);
}

long Poww(int A,int B)
{
    long res = 1;
    for (int i = 0; i < B; i++)
    {
        res = res *A;
    }
    return res;
}

long PowwMath(int A,int B)
{
    return(long)(Math.Pow(A,B));
}

PrintResult(Poww(ReadData("Введите число А"),ReadData("Введите число В")));
PrintResult(PowwMath(ReadData("Введите число А"),ReadData("Введите число В")));

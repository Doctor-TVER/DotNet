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

int VariantSumSimple(int numA)
{
    int sumOfNum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNum += i;
    }
    return sumOfNum;
}

int VariantSumGaus(int numA)
{
    int sumOfNum = 0;
    sumOfNum = ((1 + numA) * numA) / 2;
    return sumOfNum;
}

int numberA = ReadData("введите число А");
int res1 = VariantSumSimple(numberA);
int res2 = VariantSumGaus(numberA);
PrintResult("Сумма чисел от 1 до А равна: " + res1);
PrintResult("Сумма чисел от 1 до А равна: " + res2);
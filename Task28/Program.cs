// Напишите программу, которая принимает на вход число и выдаёт произведение цифр в числе.

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

long MultA(int numA)
{
    int i = 1;
    long sumOfNum = 1;
    while (i <= numA)
    {
        sumOfNum = sumOfNum * i;
        i++;
    }
    return sumOfNum;
}

long MultA1(int numA)
{
    long sumOfNum = 1;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNum = sumOfNum * i;
    }
    return sumOfNum;
}

long MultA2(int numA)
{
    if (numA == 1)
        return numA;
    return numA * MultA2(numA - 1);
}

int numberA = ReadData("введите число А");
long res1 = MultA(numberA);
long res2 = MultA1(numberA);
long res3 = MultA2(numberA);
PrintResult("Произведение чисел от 1 до А равна: " + res1);
PrintResult("Произведение чисел от 1 до А равна: " + res2);
PrintResult("Произведение чисел от 1 до А равна: " + res3);



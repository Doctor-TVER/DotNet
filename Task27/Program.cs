// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

int SumDigit(int num)
{
    int sum = 0;
    while(num>0)
    {
        sum+=num%10;
        num=num/10;
    }
    return sum;
}
int numberA = ReadData("Введите число: ");
int res =SumDigit(numberA);
PrintResult("Сумма цифр равна "+ res);

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
        sum+=1;
        num=num/10;
    }
    return sum;
}

int SumDigit2(int num)
{
    string numString = num.ToString();
    return numString.Length;
}

int SumDigit3(int num)
{
   return(int)(Math.Log10(num)+1);
}

int numberA = ReadData("Введите число: ");
int res1 =SumDigit(numberA);
int res2 =SumDigit2(numberA);
int res2 =SumDigit3(numberA);
PrintResult("Количество цифр равно "+ res1);
PrintResult("Количество цифр равно "+ res2);
PrintResult("Количество цифр равно "+ res3);

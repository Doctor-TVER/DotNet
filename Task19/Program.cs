
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

bool PalindromTest(int num)
{
    if ((num > 9999)&& (num < 100000))
    {
        if ((num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        Console.WriteLine("Число не пятизначное!");
        return false;
    }
}

void PrintResult(int num)
{
    if(PalindromTest(num))
    {
        Console.WriteLine("Это палиндром!");
    }
    else
    {
        Console.WriteLine("Это не палиндром!");
    }
    
}

int num = ReadData("Введите пятизначное число: ");

PrintResult(num);


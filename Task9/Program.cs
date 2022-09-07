
void MyVar()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
// 2 вариант
// Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
// 3 вариант
// char[] charArray = number.ToString().ToCharArray();
// Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
MyVar();
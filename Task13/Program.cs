// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void MyVar()
{
    string? inputLineA = Console.ReadLine();
    // int inputNumberA = int.Parse(inputLineA);

    if (inputLineA.Length >= 3)
    {
        char[] charArray = inputLineA.ToCharArray();
        Console.WriteLine(charArray[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

void MyVar();

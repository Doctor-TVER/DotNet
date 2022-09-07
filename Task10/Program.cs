//===================================================================================
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//===================================================================================
void MyVar()
{
    string? inputLineA = Console.ReadLine();
    // int inputNumberA = int.Parse(inputLineA);
           
    if (inputLineA.Length==3)
    {
        char[] charArray = inputLineA.ToCharArray();
        Console.WriteLine(charArray[1]);
    }
    else
    {
        Console.WriteLine("Число не 3значное");
    }
}

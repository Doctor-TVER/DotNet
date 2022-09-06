string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    if (inputNumberN > 99 && inputNumberN < 1000)
    {
        int lastDigit = inputNumberN % 10;
        Console.Write(lastDigit);
    }
}

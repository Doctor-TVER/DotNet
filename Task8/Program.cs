// ==================================================================================
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// ==================================================================================

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    B = 1;
    while (B < inputNumberN)
    {
        if (B % 2 == 0)
        {
            Console.Write(B + ", ");
        }
        B++;
    }

    Console.Write(inputNumberN);
}

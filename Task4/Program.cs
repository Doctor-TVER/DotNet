// ==================================================================================
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// ==================================================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineB);
    if (inputNumberA > inputNumberB)
    {
        if(inputNumberA > inputNumberC)
        {
            Console.WriteLine("Max число А");
        }
        else
        {
            Console.WriteLine("Max число C");
        }
    }
    else
    {
        if(inputNumberB > inputNumberC)
        {
            Console.WriteLine("Max число B");
        }
        else
        {
            Console.WriteLine("Max число C");
        }
    }
}

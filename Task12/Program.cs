// string? inputLineA = Console.ReadLine();
// string? inputLineB = Console.ReadLine();
// int inputNumberA = int.Parse(inputLineA);
// int inputNumberB = int.Parse(inputLineB);
// Console.WriteLine((inputNumberB % inputNumberA == 0) ? "Число В кратно А" : "В не кратно А" + inputNumberB % inputNumberA);

int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

void ReadData();
void ConsData();
void PrintData();

void ReadData()
{
    string? inputLineA = Console.ReadLine();
    string? inputLineB = Console.ReadLine();
    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);
}

void ConsData()
{
    result = (inputNumberB % inputNumberA == 0);
}

void PrintData()
{
    if(result)
    {
        Console.WriteLine("Число В кратно А");
    }
    else
    {
        Console.WriteLine("ВОстаток от деления" + inputNumberB % inputNumberA);
    }
}


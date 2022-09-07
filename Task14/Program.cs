string? inputLineA = Console.ReadLine();
int inputNumberA = int.Parse(inputLineA);
bool R1 = (inputNumberA%7==0);
bool R2 = (inputNumberA%23==0);
if(R1&&R2)
{
    Console.WriteLine("Число кратно 7  и 23");
}
else
{
    Console.WriteLine("Число кратно 7  или 23");
}



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


string? inputLineA = Console.ReadLine();
int inputNumberA = int.Parse(inputLineA);
if(inputNumberA==6||inputNumberA==7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будни");
}
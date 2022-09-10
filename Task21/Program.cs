
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double Calc(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите x1 ");
int x2 = ReadData("Введите x2 ");
int y1 = ReadData("Введите y1 ");
int y2 = ReadData("Введите y2 ");
int z1 = ReadData("Введите z1 ");
int z2 = ReadData("Введите z2 ");

PrintResult(Math.Round(Calc(x1, x2, y1, y2, z1, z2),2).ToString());

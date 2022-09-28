// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int AckermannFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermannFunc(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    return AckermannFunc(m, n);
}

int m = ReadData("Введите Число m: ");
int n = ReadData("Введите Число n: ");
int res = AckermannFunc(m, n);
PrintResult($"Функция Аккермана для чисел {m} и {n} = {res}");
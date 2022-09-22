// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
}

int Count(int n)
{
    int res = 0;
    for (int i = 0; i < n; i++)
        {
            int num = ReadData("Введите число: ");
            if(num > 0) res++;
        }
    return res;
}

PrintResult("Количество чисел больше ноля: ", Count(ReadData("Введите число: ")));
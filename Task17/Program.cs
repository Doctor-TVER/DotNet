int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int QuaterTest(int x,int y)
{
    if(x>0&&y>0)
    return 1;
    if(x<0&&y>0)
    return 2;
    if(x<0&&y<0)
    return 3;
    if(x>0&&y<0)
    return 4;
    
    return -1;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x=ReadData("Введите координату x");
int y=ReadData("Введите координату y");

int res=QuaterTest(x,y);

PrintResult("Точка находится в четверти: "+ res);

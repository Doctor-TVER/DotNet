void Var1()
{
    int A = new Random().Next(100, 1000);
    Console.WriteLine(A);
    int B = A / 100;
    int C = A % 10;

    Console.WriteLine(B * 10 + C);
}

void Var2()
{
    int A = new Random().Next(100, 1000);
    Console.WriteLine(A);
    char[] charArray = A.ToString().ToCharArray();
    Console.Write(charArray[0]);
    Console.WriteLine(charArray[2]);
}
Var1();
Var2();
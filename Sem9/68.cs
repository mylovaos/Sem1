Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.WriteLine("Например:");
Console.WriteLine("m = 2, n = 3 -> A(m,n) = 9");
Console.WriteLine("m = 3, n = 2 -> A(m,n) = 29");
Console.WriteLine("");

Console.WriteLine("Давайте вычислим функцию Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
int m = ReadInt("Введите m: ");
int n = ReadInt("Введите n: ");

int res = Akkerman(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {res}");


int ReadInt(string outputMessage)
{
    Console.Write(outputMessage);
    string inputMessage = Console.ReadLine();
    if (!int.TryParse(inputMessage, out int value))
    {
        Console.WriteLine("Вы ввели не число. Выходим из программы.");
        Environment.Exit(0);
    }
    if (value < 0)
    {
        Console.WriteLine("Число мне может быть отрицательным. Выходим из программы.");
        Environment.Exit(0);
    }
    return value;
}

int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}

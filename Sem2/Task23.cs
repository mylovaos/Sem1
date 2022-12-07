int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i*i*i} ");
}

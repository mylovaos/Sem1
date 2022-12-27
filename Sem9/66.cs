Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("Например:");
Console.WriteLine("M = 1; N = 15 -> 120");
Console.WriteLine("M = 4; N = 8. -> 30");
Console.WriteLine("");

Console.WriteLine("Давайте найдём сумму натуральных элементов в промежутке от M до N.");
int fromNumber = ReadInt("Введите M: ");
int toNumber = ReadInt("Введите N: ");

int sum = 0;
sum = FindSum(fromNumber, toNumber);
Console.WriteLine($"M = {fromNumber}; N = {toNumber} -> {sum}");

int FindSum(int fromNumber, int toNumber)
{
    if (fromNumber > toNumber)
        return sum;
    sum += fromNumber;
    fromNumber++;
    return FindSum(fromNumber, toNumber);
}

int ReadInt(string outputMessage)
{
    Console.Write(outputMessage);
    string inputMessage = Console.ReadLine();
    if (!int.TryParse(inputMessage, out int value))
    {
        Console.WriteLine("Вы ввели не число. Выходим из программы.");
        Environment.Exit(0);
    }
    return Convert.ToInt32(inputMessage);

}

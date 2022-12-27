Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
Console.WriteLine("Например:");
Console.WriteLine("5 -> '5, 4, 3, 2, 1'");
Console.WriteLine("8 -> '8, 7, 6, 5, 4, 3, 2, 1'");
Console.WriteLine("");

Console.WriteLine("Давайте выведем все натуральные числа в промежутке от N до 1");
int fromNumber = ReadInt("Введите N: ");
int toNumber = 1;

string outputMessage = fromNumber + " -> '";
outputMessage = PrintNumbers(fromNumber, toNumber);
Console.WriteLine(outputMessage);

string PrintNumbers(int fromNumber, int toNumber)
{
    if (fromNumber < toNumber)
        return outputMessage;
    outputMessage += fromNumber;
    if (fromNumber != toNumber)
        outputMessage += ", ";
    else
        outputMessage += "'";
    fromNumber--;
    return PrintNumbers(fromNumber, toNumber);
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

Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.WriteLine("b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
Console.WriteLine("");

double k1 = ReadDouble("Введите k1: ");
double b1 = ReadDouble("Введите b1: ");
double k2 = ReadDouble("Введите k2: ");
double b2 = ReadDouble("Введите b2: ");

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
    Environment.Exit(0);
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
    Environment.Exit(0);
}

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");

double ReadDouble(string outputMessage)
{
    Console.WriteLine(outputMessage);
    string inputMessage = Console.ReadLine();
    if (!double.TryParse(inputMessage, out double value))
    {
        Console.WriteLine("Вы ввели не вещественное число. Выходим из программы.");
        Environment.Exit(0);
    }
    return Convert.ToDouble(inputMessage);
}

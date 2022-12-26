Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("Размер массива, минимальное значение и максимальное значение вводим через консоль");
Console.WriteLine("Для генерации вещественных числе, по аналогии с int, есть функция NextDouble()");
Console.WriteLine("Например:");
Console.WriteLine("[3 7 22 2 78] -> 76");
Console.WriteLine("");

int lenArray = ReadInt("Введите размер массива: ");
double minInArray = ReadDouble("Введите минимальное значение элемента в массиве: ");
double maxInArray = ReadDouble("Введите максимальное значение элемента в массиве: ");
double[] randomArray = FillArray(lenArray, minInArray, maxInArray);

Console.WriteLine("Результат: ");
Console.WriteLine(BuildArrayAsString(randomArray) + " -> " + (randomArray.Max() - randomArray.Min()));

int ReadInt(string outputMessage)
{
    Console.WriteLine(outputMessage);
    string inputMessage = Console.ReadLine();
    if (!int.TryParse(inputMessage, out int value))
    {
        Console.WriteLine("Вы ввели не число. Выходим из программы.");
        Environment.Exit(0);
    }
    return Convert.ToInt32(inputMessage);

}

double ReadDouble(string outputMessage)
{
    Console.WriteLine(outputMessage);
    string inputMessage = Console.ReadLine();
    if (!double.TryParse(inputMessage, out double value))
    {
        Console.WriteLine("Вы ввели не вешественное число. Выходим из программы.");
        Environment.Exit(0);
    }
    return Convert.ToDouble(inputMessage);

}

double[] FillArray(int lenArray, double minInArray, double maxInArray)
{
    double[] randomArray = new double[lenArray];
    for (int i = 0; i < randomArray.Length; i++)
    {
        var next = new Random().NextDouble();
        randomArray[i] = minInArray + (next * (maxInArray - minInArray));
    }
    return randomArray;
}

string BuildArrayAsString(double[] randomArray)
{
    string output = "";
    for (int i = 0; i < randomArray.Length; i++)
    {
        output = output + randomArray[i];
        if (i < randomArray.Length - 1)
        {
            output = output + ", ";
        }
    }

    return "[" + output + "]";
}

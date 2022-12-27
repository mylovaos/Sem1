Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine("Например:");
Console.WriteLine("1 4 7 2");
Console.WriteLine("5 9 2 3");
Console.WriteLine("8 4 2 4");
Console.WriteLine("5 2 6 7");
Console.WriteLine("Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка");


Console.WriteLine("Давайте сгенерируем для вас массив");
int widthArray = ReadInt("Введите m: ");
int heigthArray = ReadInt("Введите n: ");
double[,] randomArray = FillArray(widthArray, heigthArray);
Console.WriteLine("Ваш массив: ");
PrintArray(randomArray);

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {GetRowIndexWithMinSum(randomArray)} строка (отсчет с 0)");

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

double[,] FillArray(int widthArray, int heigthArray)
{
    double[,] randomArray = new double[widthArray, heigthArray];
    int minInArray = -100;
    int maxInArray = 100;
    for (int i = 0; i < widthArray; i++)
    {
        for (int j = 0; j < heigthArray; j++)
        {
            var next = new Random().NextDouble();
            randomArray[i, j] = Math.Round(minInArray + (next * (maxInArray - minInArray)), 2);
        }

    }
    return randomArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int GetRowIndexWithMinSum(double[,] randomArray)
{
    int minRowNumber = 0;
    double minRowSum = 0;
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        double rowSum = 0;
        for (int j = 0; j <= randomArray.GetLength(1) - 1; j++)
        {
            rowSum += randomArray[i, j];
        }
        if (rowSum < minRowSum)
        {
            minRowNumber = i;
            minRowSum = rowSum;
        }
    }
    return minRowNumber;
}

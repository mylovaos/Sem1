Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.WriteLine("Например:");
Console.WriteLine("m = 3, n = 4.");
Console.WriteLine("0,5 7 -2 -0,2");
Console.WriteLine("1 -3,3 8 -9,9");
Console.WriteLine("8 7,8 -7,1 9");
Console.WriteLine("");

int widthArray = ReadInt("Введите m: ");
int heigthArray = ReadInt("Введите n: ");
double[,] randomArray = FillArray(widthArray, heigthArray);

Console.WriteLine("Результат: ");
PrintArray(randomArray);

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

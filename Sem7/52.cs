Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Например:");
Console.WriteLine("1 4 7 2");
Console.WriteLine("5 9 2 3");
Console.WriteLine("8 4 2 4");
Console.WriteLine("Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.");
Console.WriteLine("");


Console.WriteLine("Давайте сгенерируем для вас массив");
int widthArray = ReadInt("Введите m: ");
int heigthArray = ReadInt("Введите n: ");
double[,] randomArray = FillArray(widthArray, heigthArray);
Console.WriteLine("Ваш массив: ");
PrintArray(randomArray);
string outputResult = "";
for (int i = 0; i < randomArray.GetLength(1); i++)
{
    outputResult += GetAverageOfColumn(randomArray, i) + "; ";
}

Console.WriteLine("Среднее арифметическое каждого столбца: " + outputResult);

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
    int minInArray = -0;
    int maxInArray = 100;
    for (int i = 0; i < widthArray; i++)
    {
        for (int j = 0; j < heigthArray; j++)
        {
            var next = new Random().NextDouble();
            randomArray[i, j] = Math.Round(minInArray + (next * (maxInArray - minInArray)), 0);
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

double GetAverageOfColumn(double[,] array, int column)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, column];
    }
    return Math.Round(sum / array.GetLength(0), 2);
}

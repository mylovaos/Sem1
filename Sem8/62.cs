Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
Console.WriteLine("Например:");
Console.WriteLine("01 02 03 04");
Console.WriteLine("12 13 14 05");
Console.WriteLine("11 16 15 06");
Console.WriteLine("11 16 15 06");
Console.WriteLine("10 09 08 07");
Console.WriteLine("");

int widthAndHeigth = ReadInt("Введите размерность массива: ");
int[,] array = FillArraySpiral(widthAndHeigth);

Console.WriteLine($"Ваш массив размером {widthAndHeigth}x{widthAndHeigth} заполненный по спирили: ");
PrintArray(array, widthAndHeigth*widthAndHeigth);

int[,] FillArraySpiral(int widthAndHeigth)
{
    int n = widthAndHeigth;
    int m = widthAndHeigth;
    int iBeg = 0, iFin = 0, jBeg = 0, jFin = 0;

    int k = 1;
    int i = 0;
    int j = 0;

    int[,] arr = new int[m, n];

    while (k <= n * m)
    {
        arr[i, j] = k;
        if (i == iBeg && j < m - jFin - 1)
            ++j;
        else if (j == m - jFin - 1 && i < n - iFin - 1)
            ++i;
        else if (i == n - iFin - 1 && j > jBeg)
            --j;
        else
            --i;

        if ((i == iBeg + 1) && (j == jBeg) && (jBeg != m - jFin - 1))
        {
            ++iBeg;
            ++iFin;
            ++jBeg;
            ++jFin;
        }
        ++k;
    }

    return arr;
}

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

void PrintArray(int[,] array, int maxValue)
{
    string fillPattern = "";
    for (int i = 0; i < maxValue.ToString().Length; i++) 
    {
        fillPattern += "0";
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString(fillPattern) + "\t");
        }
        Console.WriteLine();
    }
}

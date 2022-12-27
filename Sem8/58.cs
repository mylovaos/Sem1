Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
Console.WriteLine("Например:");
Console.WriteLine("2 4 | 3 4");
Console.WriteLine("3 2 | 3 3");
Console.WriteLine("Результирующая матрица будет:");
Console.WriteLine("18 20");
Console.WriteLine("15 18");
Console.WriteLine("");


Console.WriteLine("Давайте сгенерируем для вас мартицы");
int widthArray = ReadInt("Введите m: ");
int heigthArray = ReadInt("Введите n: ");
int[,] randomArrayFirst = FillArray(widthArray, heigthArray);
int[,] randomArraySecond = FillArray(widthArray, heigthArray);
// int[,] randomArrayFirst = { { 2, 4 }, { 3, 2 } };
// int[,] randomArraySecond = { { 3, 4 }, { 3, 3 } };
Console.WriteLine("Матрица 1: ");
PrintArray(randomArrayFirst);
Console.WriteLine("Матрица 2: ");
PrintArray(randomArraySecond);
Console.WriteLine("Результирующая матрица: ");
PrintArray(GetMultiplicationMatrix(randomArrayFirst, randomArraySecond));

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

int[,] FillArray(int widthArray, int heigthArray)
{
    int[,] randomArray = new int[widthArray, heigthArray];
    int minInArray = 0;
    int maxInArray = 10;
    for (int i = 0; i < widthArray; i++)
    {
        for (int j = 0; j < heigthArray; j++)
        {
            randomArray[i, j] = new Random().Next(minInArray, maxInArray);
        }

    }
    return randomArray;
}

void PrintArray(int[,] array)
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

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayC[i, j] = 0;

            for (int k = 0; k < arrayA.GetLength(0); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}

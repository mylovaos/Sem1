using System.Linq;

Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.WriteLine("Например:");
Console.WriteLine("2 x 2 x 2");
Console.WriteLine("66(0,0,0) 25(0,1,0)");
Console.WriteLine("34(1,0,0) 41(1,1,0)");
Console.WriteLine("27(0,0,1) 90(0,1,1)");
Console.WriteLine("26(1,0,1) 55(1,1,1)");
Console.WriteLine("");

int row = ReadInt("Введите кол-во строк в матрице: ");
int col = ReadInt("Введите кол-во столбцов в матрице: ");
int dep = ReadInt("Введите глубину матрицы: ");

int[] unique = { };
int[,,] array3D = CreateMatrix(row, col, dep, 10, 99);
PrintMatrix(array3D);

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

int[,,] CreateMatrix(int row, int col, int dep, int min, int max)
{
    if ((row * col * dep) > (max - min))
    {
        Console.WriteLine($"Массив размера {row}x{col}x{dep} не получится заполнить уникальными числами от {min} до {max}. Не хватит уникальных значений.");
        Environment.Exit(0);
    }
    int[,,] matrix = new int[row, col, dep];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = GetUniqueValue(min, max);
            }
        }
    }
    return matrix;
}

int GetUniqueValue(int min, int max)
{
    int rnd = new Random().Next(min, max);
    if (unique.Contains(rnd))
    {
        GetUniqueValue(min, max);
    }
    unique = unique.Append(rnd).ToArray();
    return rnd;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],1}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}

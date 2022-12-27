Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine("Например:");
Console.WriteLine("1 4 7 2");
Console.WriteLine("5 9 2 3");
Console.WriteLine("8 4 2 4");
Console.WriteLine("В итоге получается вот такой массив:");
Console.WriteLine("7 4 2 1");
Console.WriteLine("9 5 3 2");
Console.WriteLine("8 4 4 2");
Console.WriteLine("");

Console.WriteLine("Давайте сгенерируем для вас массив");
int widthArray = ReadInt("Введите m: ");
int heigthArray = ReadInt("Введите n: ");
double[,] randomArray = FillArray(widthArray, heigthArray);
Console.WriteLine("Ваш массив: ");
PrintArray(randomArray);

// Тут просто перебором сортируем элементы
// Можно изящнее сделать и с меньшим количеством шагов, но придумалось пока так
for (int i = 0; i < randomArray.GetLength(0); i++) // Бежим по строкам
{
    for (int k = 0; k < randomArray.GetLength(1); k++) // Бежим по элементам строки
    {
        for (int j = 0; j < randomArray.GetLength(1) - 1; j++)
        {
            double curr = randomArray[i, j];
            double next = randomArray[i, j + 1];
            if (next < curr)
            {
                randomArray[i, j] = next;
                randomArray[i, j + 1] = curr;
            }
        }
    }
}
Console.WriteLine("Отсортированный по строкам массив: ");
PrintArray(randomArray);

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

Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Например:");
Console.WriteLine("1 4 7 2");
Console.WriteLine("5 9 2 3");
Console.WriteLine("8 4 2 4");
Console.WriteLine("1");
Console.WriteLine("7 -> такого числа в массиве нет");
Console.WriteLine("");

Console.WriteLine("Давайте сгенерируем для вас массив");
int widthArray = ReadInt("Введите m: ");
int heigthArray = ReadInt("Введите n: ");
double[,] randomArray = FillArray(widthArray, heigthArray);
Console.WriteLine("Ваш массив: ");
PrintArray(randomArray);

Console.WriteLine("Теперь давайте введем позиции элемента массива коротый вы хотите получить:");
int i = ReadInt("");
int j = ReadInt("");

try
{
  Console.WriteLine("Запрощшенный элемент иммет значение: " + randomArray[i,j]);
}
catch(IndexOutOfRangeException exception)
{
   Console.WriteLine("Такого элемента в массиве нет");
   Console.WriteLine("Детали exception: ");
   Console.WriteLine(exception);
   // Само собой можно было сделать конструкцию из if, в которой проверить кол-во строк и столбцов в массиве и сравнить с тем что запросил пользователь.
   // Псевдокод:
   // int rowsOrHeight = array.GetLength(0);
   // int colsOrWidth = arrayy.GetLength(1);
   // if (i > rowsOrHeight && j > colsOrWidth) { Такого элемента в массиве нет }
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

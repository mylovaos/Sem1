Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("Размер массива, минимальное значение и максимальное значение вводим через консоль");
Console.WriteLine("Например:");
Console.WriteLine("[3, 7, 23, 12] -> 19");
Console.WriteLine("[-4, -6, 89, 6] -> 0");
Console.WriteLine("");



int lenArray = ReadInt("Введите размер массива: ");
int minNumberInArray = ReadInt("Введите минимальное значение элемента в массиве: ");
int maxNumberInArray = ReadInt("Введите максимальное значение элемента в массиве: ");
int[] randomArray = FillArray(lenArray, minNumberInArray, maxNumberInArray);
int sumOdd = SumOddInArray(randomArray);

Console.WriteLine("Результат: ");
Console.WriteLine(BuildArrayAsString(randomArray) + " -> " + sumOdd);

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

int[] FillArray(int lenArray, int minNumberInArray, int maxNumberInArray)
{
    int[] randomArray = new int[lenArray];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(minNumberInArray, maxNumberInArray);
    }
    return randomArray;
}

string BuildArrayAsString(int[] randomArray)
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

int SumOddInArray(int[] randomArray)
{
    int sum = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + randomArray[i];
        }

    }
    return sum;
}

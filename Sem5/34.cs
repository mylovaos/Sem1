Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("Размер массива вводим через консоль");
Console.WriteLine("Например:");
Console.WriteLine("[345, 897, 568, 234] -> 2");
Console.WriteLine("");

int lenArray = ReadInt("Введите размер массива: ");
int[] randomArray = FillArray(lenArray);
string output = BuildOutput(randomArray);
int countEven = CountEvenInArray(randomArray);
Console.WriteLine(output + " -> " + countEven);

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

int[] FillArray(int lenArray)
{
    int[] randomArray = new int[lenArray];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(100, 999);
    }
    return randomArray;
}

string BuildOutput(int[] randomArray)
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

int CountEvenInArray(int[] randomArray)
{
    int count = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
        {
            count = count + 1;
        }

    }
    return count;
}

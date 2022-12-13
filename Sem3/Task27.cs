Console.WriteLine("Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Например:");
Console.WriteLine("82 -> 10");
Console.WriteLine("9012 -> 12");
Console.WriteLine("");

int number = ReadInt("Введите число: ");
int lenghtOfNumber = NumberLenght(number);
int sum = SumOfNumbers(number, lenghtOfNumber);
Console.WriteLine(number + " -> " + sum);

int ReadInt(string outputMessage)
{
    Console.WriteLine(outputMessage);
    string inputMessage = Console.ReadLine();
    if(!int.TryParse(inputMessage, out int value)){
        Console.WriteLine("Вы ввели не число. Выходим из программы.");
        Environment.Exit(0); 
    }
    return Convert.ToInt32(inputMessage);
    
}

int NumberLenght(int number)
{
    int index = 0;
    while (number > 0)
    {
        number /= 10;
        index++;
    }
    return index;
}

int SumOfNumbers(int number, int lenght)
{
    int sum = 0;
    for (int i = 1; i <= lenght; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.WriteLine("Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Например:");
Console.WriteLine("3, 5 -> 243");
Console.WriteLine("2, 4 -> 16");
Console.WriteLine("");

int numberA = ReadInt("Введите A: ");
int numberB = ReadInt("Введите B: ");
ToDegree(numberA, numberB);

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

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в " + b + " степени = " + result);
}

Console.WriteLine("Задача 29. Напишите программу, которая задаёт массив из N элементов и выводит их на экран.");
Console.WriteLine("Например:");
Console.WriteLine("5 -> [1, 2, 5, 7, 19]");
Console.WriteLine("3 -> [6, 1, 33]");
Console.WriteLine("");

int lenArray = ReadInt("Введите длинну массива: ");
int[] randomArray = new int[lenArray];
string output = "";
fillArrayAndBuildOutput();
Console.WriteLine(lenArray + " -> [" + output + "]");


void fillArrayAndBuildOutput()
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(1,9);
        // Build output message
        output = output + randomArray[i];
        if (i < randomArray.Length - 1) {
            output = output + ", ";
        }
    }
}

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

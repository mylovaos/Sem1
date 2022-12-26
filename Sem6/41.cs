Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("Например:");
Console.WriteLine("0, 7, 8, -2, -2 -> 2");
Console.WriteLine("1, -7, 567, 89, 223-> 3");
Console.WriteLine("");

Console.WriteLine("Введите числа через заятую (напирмер: 1,2,-4,45,9453): ");
string inputMessage = Console.ReadLine();
int[] userArray = ConvertStringToArray(inputMessage);


Console.WriteLine(BuildArrayAsString(userArray) + " -> " + CountMoreThanZero(userArray));


int[] ConvertStringToArray(string inputMessage)
{
    string[] strigArray = inputMessage.Replace(" ", "").Split(',');
    int[] intArray = new int[strigArray.Length];
    for (int i = 0; i < strigArray.Length; i++)
    {
        if (!int.TryParse(strigArray[i], out int value))
        {
            Console.WriteLine("Элемент '" + strigArray[i] + "' под индексом " + i + " не число. Выходим из программы.");
            Environment.Exit(0);
        }
        intArray[i] = Convert.ToInt32(strigArray[i]);
    }
    return intArray;
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

    return output;
}

int CountMoreThanZero(int[] userArray)
{
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

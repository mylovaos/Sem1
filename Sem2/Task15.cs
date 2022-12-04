void isHoliday(int a){
    if (a == 6 || a  == 7) {
        Console.WriteLine("Да");
    } else if(a == 1 || a  == 2 || a == 3 || a  == 4 || a == 5) {
        Console.WriteLine("Нет");
    } else {
        Console.WriteLine("Такого дня недели нет");
    }
}

Console.WriteLine("Введите день недели (1-7): ");
string input = Console.ReadLine();
if(int.TryParse(input, out int value)){
    isHoliday(value);
} else {
    Console.WriteLine("Вы ввели не число");
}

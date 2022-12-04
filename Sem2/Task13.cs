void getThirdLetter(int a){
    string output = a.ToString();
    if (a < 100 && a > -100) {
        Console.WriteLine("3ей цифры нет");
    } else if(a > 0) {
        Console.WriteLine("{0}->{1}",output, output[2]);
    } else if (a <0) {
        a = a - a - a;
        output = a.ToString();
        Console.WriteLine("-{0}->{1}",output, output[2]);
    }

}

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
if(int.TryParse(input, out int value)){
    getThirdLetter(value);
} else {
    Console.WriteLine("Вы ввели не число");
}



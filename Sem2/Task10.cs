void getSecondLetter(String a){
    Console.WriteLine("{0}->{1}",a, a[1]);
}

Console.WriteLine("Введите трехзначное число.");
string input = Console.ReadLine();
if(input.Length != 3) {
    Console.WriteLine("Вы ввели не 3 знака");
} else {
    if(int.TryParse(input, out int value)){
        getSecondLetter(input);
    } else {
        Console.WriteLine("Вы ввели не число");
    }
}
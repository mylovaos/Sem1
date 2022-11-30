Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.Write("max = " + a + " min = " + b);
}
else
{
    Console.Write("max = " + b + " min = " + a);
}
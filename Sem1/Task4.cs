Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите c: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}
Console.Write("max = " + max);
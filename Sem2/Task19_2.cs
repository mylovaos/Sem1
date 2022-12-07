Console.WriteLine("Введите число ");
string number = Console.ReadLine();

int num = int.Parse(number);
int left = num;
int rev = 0;
while(Convert.ToBoolean(left)) 
{
   int r = left % 10;   
   rev = rev * 10 + r;
   left = left / 10;  
}

bool isPalindrome = rev == num;

Console.WriteLine(isPalindrome);
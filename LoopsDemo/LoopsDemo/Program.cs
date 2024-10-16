/*
Console.WriteLine("How many times?");
string inputStr = Console.ReadLine();

int input = Convert.ToInt32(inputStr);

for (int i = 1; i <= input; i++)
    Console.WriteLine("Hello "+i);

Console.WriteLine("What multiplication table do you want?");
string numStr = Console.ReadLine();
int num = Convert.ToInt32(numStr);

for (int i = 1; i <= 10; i++)
    Console.WriteLine(num+" * "+i+" = "+(num*i));
*/

for (int i = 5; i >= 0; i--)
{
    Console.WriteLine(i);
    Thread.Sleep(1000);
}
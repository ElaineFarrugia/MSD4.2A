using System.Collections.Generic;

List<string> names = new List<string>();

while (true)
{
    Console.WriteLine("Enter name: ");
    string input = Console.ReadLine();

    if (input == "stop")
        break;

    if (names.Contains(input))
        Console.WriteLine("Duplicate");
    else
        names.Add(input);
}

foreach (string name in names)
    { Console.WriteLine(name); }

Random generator = new Random();
int randomNum = generator.Next(0, names.Count);

Console.WriteLine("The 1st winner is: " + names[randomNum]);

names.RemoveAt(randomNum);

int randomNum2 = generator.Next(0, names.Count);

Console.WriteLine("The 2nd winner is: " + names[randomNum2]);
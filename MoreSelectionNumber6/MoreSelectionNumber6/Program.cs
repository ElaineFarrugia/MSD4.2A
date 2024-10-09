Console.WriteLine("Rolling dice 1");

Random generator = new Random();
int dice1 = generator.Next(1, 7);
Thread.Sleep(1000);
Console.WriteLine("1st number generated: " + dice1);

int dice2 = generator.Next(1, 7);
Thread.Sleep(1000);
Console.WriteLine("2nd number generated: " + dice2);

int total = dice1 + dice2;
Console.WriteLine("You got a total of: " + total);

if ((total == 7) || (total == 11))
    Console.WriteLine("You win!");
else if (total == 2)
    Console.WriteLine("Snake Eyes");
else
    Console.WriteLine("Try again!");
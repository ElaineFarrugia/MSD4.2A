Random generator = new Random();
char choice = ' ';

do
{
    int rand = generator.Next(1, 4);

    char computerChoice = ' ';

    if (rand == 1)
        computerChoice = 'r';
    else if (rand == 2)
        computerChoice = 'p';
    else
        computerChoice = 's';

    Console.WriteLine("Computer chose " + computerChoice);

    Console.WriteLine("Choose Rock(r), Paper(p) or Scissors(s)");

    char userInput = Console.ReadKey().KeyChar;

    Console.WriteLine();

    if ((userInput == 'r' && computerChoice == 's')
        || (userInput == 's' && computerChoice == 'p')
        || (userInput == 'p' && computerChoice == 'r'))
        Console.WriteLine("You win!");
    else if (userInput == computerChoice)
        Console.WriteLine("It's a tie!");
    else
        Console.WriteLine("You Lose!");

    Console.WriteLine("Do you want to play again? (y/n)");
    choice = Console.ReadKey().KeyChar;
} while (choice == 'y');

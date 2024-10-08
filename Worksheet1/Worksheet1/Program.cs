string sequence = "fdsfd76"; //variable declaration and instantiation

Console.WriteLine("Remember this sequence: " + sequence);

Thread.Sleep(5000); //5s delay

Console.Clear();

Console.WriteLine("Type in the sequence:");
string userInput = Console.ReadLine();

if (userInput == sequence)
    Console.WriteLine("Correct! You have good memory!");
else
    Console.WriteLine("Sorry, the correct sequence was " + sequence);
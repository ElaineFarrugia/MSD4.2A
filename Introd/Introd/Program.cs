
int generatedNumber; //declare variable to hold generated number

Random rand = new Random();    //prepare to generate a random number
generatedNumber = rand.Next(1, 11); //generate random no. from 1-10

//Console.WriteLine(generatedNumber); //print generated number

Console.WriteLine("I selected a number between 1 and 10. Can you guess it?");

string userInput = Console.ReadLine();  //read user input
int userInputInt = Convert.ToInt32(userInput); //convert user input to int

if (generatedNumber == userInputInt)
    Console.WriteLine("You guessed!");
else
    Console.WriteLine("Sorry, you did not guess!");

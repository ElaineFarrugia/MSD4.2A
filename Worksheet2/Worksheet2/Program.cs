Console.WriteLine("Welcome to the character editor");
Console.WriteLine("Enter your character's name:");
string name = Console.ReadLine();

Console.WriteLine("You have a total of 10 points to allocate.");

Console.WriteLine("Enter points for Strength: ");
string strength = Console.ReadLine();
int strengthInt = Convert.ToInt32(strength);

Console.WriteLine("Enter points for Agility: ");
string agility = Console.ReadLine();
int agilityInt = Convert.ToInt32(agility);

Console.WriteLine("Enter points for Intelligence: ");
string intelligence = Console.ReadLine();
int intelligenceInt = Convert.ToInt32(intelligence);

int total = strengthInt + agilityInt + intelligenceInt;

//WAY 1
if ((total == 10) && (strengthInt > 0) && (agilityInt > 0)
                                       && (intelligenceInt > 0))
    Console.WriteLine("Character " + name + " creation was successful");
else
    Console.WriteLine("There was a problem while creating character");

//WAY 2
if ((total != 10) || (strengthInt == 0) || (agilityInt == 0)
                                        || (intelligenceInt == 0))
    Console.WriteLine("There was a problem while creating character");
else
    Console.WriteLine("Character " + name + " creation was successful");

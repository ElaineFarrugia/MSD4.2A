Console.WriteLine("Enter the theory mark:");
string theoryMark = Console.ReadLine();

Console.WriteLine("Enter the practical mark:");
string practiceMark = Console.ReadLine();

int theoryMarkInt = Convert.ToInt32(theoryMark); //convert to int
int practiceMarkInt = Convert.ToInt32(practiceMark);//convert to int

int total = theoryMarkInt + practiceMarkInt; //find total

//check conditions of passing the test
if ((theoryMarkInt >= 50) && (practiceMarkInt >= 50) && (total >= 125))
{
    Console.WriteLine("Congratulations you passed!");    
}
else
{
    Console.WriteLine("Unfortunately you have failed the test!");
}




using System.Collections.Generic;

List<string> myList = new List<string>();

myList.Add("Mercury");
myList.Add("Venus");
myList.Add("Mars");
myList.Add("Jupiter");
myList.Add("Saturn");
myList.Add("Uranus");
myList.Add("Neptune");
myList.Add("Pluto");

Console.WriteLine("Number of items: "+myList.Count);
Console.WriteLine("First item in list: " + myList[0]);

int lastIndex = myList.Count - 1;
Console.WriteLine("Last item in list: " + myList[lastIndex]);

Console.WriteLine("All items: ");
foreach (string item in myList)
    Console.WriteLine(item);

//OR
/*for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}*/

myList.Insert(2, "Earth");

Console.WriteLine("After adding Earth");
foreach (string item in myList)
    Console.WriteLine(item);

myList.Remove("Pluto"); //remove by value
//OR
//myList.RemoveAt(myList.Count - 1); //by index

Console.WriteLine("After removing Pluto");
foreach (string item in myList)
    Console.WriteLine(item);

//replace "Mars" with "The Red Planet"
int index = myList.IndexOf("Mars");
myList[index] = "The Red Planet";

Console.WriteLine("After renaming Mars");
foreach (string item in myList)
    Console.WriteLine(item);


//find out whether "Moon" is in the list
if (myList.Contains("Moon"))
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");



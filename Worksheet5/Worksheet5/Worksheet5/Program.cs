using System.Collections.Generic;

List<int> correctList = new List<int>();
List<int> inputList = new List<int>();

Random generator = new Random();

for (int i = 1; i <= 10; i++)
{
    int num1 = generator.Next(1, 10);
    int num2 = generator.Next(1, 10);

    int op = generator.Next(1, 3);

    if (op == 1) //+
    {
        Console.WriteLine("What is " + num1 + " + " + num2 + "?");
        string inputStr = Console.ReadLine();

        try
        {
            int input = Convert.ToInt32(inputStr);

            inputList.Add(input);
        }             
        catch
        {
            inputList.Add(-1);
        }

        int correctAnswer = num1 + num2;
        correctList.Add(correctAnswer);
    }
    else //*
    {
        Console.WriteLine("What is " + num1 + " * " + num2 + "?");
        string inputStr = Console.ReadLine();
        try
        {
            int input = Convert.ToInt32(inputStr);

            inputList.Add(input);
        }
        catch
        {
            inputList.Add(-1);
        }
        int correctAnswer = num1 * num2;
        correctList.Add(correctAnswer);
    }
}

int score = 0;

for (int i = 0; i < 10; i++)
{
    if (correctList[i] == inputList[i])
    {
        score++;
    }
}

Console.WriteLine("Score: " + score + " out of 10");

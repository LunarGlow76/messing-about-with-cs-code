using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         //DATA TYPES AND VARIABLES
        int x;
        int y;

        x = 7; 
        y = 3 + x;

        Console.WriteLine(y);


        Console.WriteLine("What is your name?");
        Console.Write("Type out your first name > ");
        string myFirstName = Console.ReadLine();

        Console.Write("Type out your second name > ");
        string myLastName = Console.ReadLine();

        Console.WriteLine($"So, you must be {myFirstName} {myLastName}...");
        */

        /*
         // IF STATEMENT
        Console.WriteLine("Choose a door, 1, 2, or 3:");
        Console.Write("> ");
        string userValue = Console.ReadLine();

        string lMessage = "You Lose!";

        if (userValue == "1")
            Console.WriteLine("You WIN! (nothing)");

        else if (userValue == "2")
            Console.WriteLine(lMessage);

        else if (userValue == "3")
            Console.WriteLine(lMessage);
        
        else
        {
            Console.WriteLine($"Please pick a value of 1, 2, or 3. {lMessage}");
        }
        */

        /*
        Console.WriteLine("Choose a door, 1, 2, or 3:");
        Console.Write("> ");
        string userValue = Console.ReadLine();

                                //if userValue 1 then whats after the ?, if not it goes to whats after colon
        string message = (userValue == "1") ? "a boat" : "a strand of lint";
        Console.WriteLine("You entered {0}, and won {1}", userValue, message);
        */

        /*
         //ITERATION
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 7)
            {
                Console.WriteLine("Found seven!");
                break;
            }
        }

        for (int myValue = 8; myValue < 100; myValue++)
        {
            Console.WriteLine(myValue);
                if (myValue == 69)
                {
                    Console.WriteLine("nice.");
                    break;
                }
        }
        */

        /* //ARRAYS
         
        int[] numbers = new int[5];

        numbers[0] = 4;
        numbers[1] = 8;
        numbers[2] = 15;
        numbers[3] = 16;
        numbers[4] = 23;

        Console.WriteLine(numbers[1]);
        */

        // int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

        //string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

        /*
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        */

        //up and below do same thing but lower is less text

        /*
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        

        string zig = ".tnaw yeht tahw teg elpoep rehto pleh uoy fi efil fo tuo tnaw uoy tahw teg nac uoY";

        char[] charArray = zig.ToCharArray();
           Array.Reverse(charArray);

        foreach (char zigChar in charArray)
        {
            Console.Write(zigChar);
        }
        */

        /*
         //METHODS
        Console.Write("What is your first name? > ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? > ");
        string lastName = Console.ReadLine();

        Console.Write("What city do you live in? > ");
        string city = Console.ReadLine();


        Console.WriteLine("Results: ");
        ReverseString(firstName);
        ReverseString(lastName);
        ReverseString(city);
        
    }

    private static void ReverseString(string message)
    {
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        foreach (char item in messageArray)
        {
            Console.Write(item);
        }
       Console.Write(" ");
    }
        */

        /*
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 20;
        int guess;
        int number;
        int guesses;

        while (playAgain) 
        {
            guess = 0;
            guesses = 0;
            string response = "";
            number = random.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine($"Guess a number between {min} and {max}!"); 
                   string? input = Console.ReadLine();
                   int.TryParse(input, out guess);
                
                Console.WriteLine($"Guess: {guess}");

                guesses += 1;

                if (guess > number)
                {
                    Console.WriteLine($"{guess} is too high!");
                }

                else if (guess < number)
                {
                    Console.WriteLine($"{guess} is too low!");
                }

                if (guess == number)
                {
                    Console.WriteLine("YOU WIN!");
                    Console.WriteLine($"The number is {number}!");
                    Console.WriteLine($"Number of guesses: {guesses}");

                    Console.Write("Would you like to play again? (y/n) > ");
                    response = Console.ReadLine();
                    response = response.ToLower();

                    if (response == "y")
                    {
                        playAgain = true;
                    }

                    else
                    {
                        playAgain = false;
                    }
                }

            }

        }

        Console.WriteLine("Thanks for playing!");
 */

        /*
        string myString = "Dancing queen is only seventeen.";
        string buildUp = "";
        
        foreach (char c in myString)
        {
            buildUp += c;
            Console.WriteLine(buildUp);
            
        }
        */

        /*
        Console.Write("Enter your first number > ");
        string input1 = Console.ReadLine();

        Console.Write("Enter your second number > ");
        string input2 = Console.ReadLine();

        Console.Write("Enter your third number > ");
        string input3 = Console.ReadLine();

        double num1 = Convert.ToDouble(input1);
        double num2 = Convert.ToDouble(input2);
        double num3 = Convert.ToDouble(input3);

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"{num1} is the biggest!");
        }

        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine(num2 + " is the biggest!");
        }

        else
        {
            Console.WriteLine(num3 + " is the biggest!");
        }
        */

     //Safe Cracker Code cracker safe :0
        Console.Write("Please enter a 2 digit code > ");
        string input = Console.ReadLine();
        int.TryParse(input, out int code);

        if (code < 10 || code > 99)
        {
            Console.WriteLine("Please enter a valid 2 digit code.");
        }
        else
        {
            Random random = new Random();
            bool numberFound = false;
            int attempts = 0;

            while (!numberFound)
            {
                int guess = random.Next(0, 100);
                Console.WriteLine(guess);
                attempts++;
                if (guess == code)
                {
                    Console.WriteLine("I found your code!");
                    break;
                }

                if (attempts > 200)
                {
                    Console.WriteLine("Tried too many times, stopping search.");
                    break;
                }
            }
        }

    }

}
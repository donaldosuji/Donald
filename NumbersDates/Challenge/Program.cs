DateTime now = DateTime.Today;
DateTime userInput;

bool exit = false;

while (exit == false)
{
    Console.WriteLine("Enter a Date in the correct format (e.g., 2024-06-20):");
    string userInputString = Console.ReadLine();

    if (DateTime.TryParse(userInputString, out userInput))
    {
        Console.WriteLine("You entered a valid date: " + userInput.ToString("d"));
        if (userInput > now)
        {
            int[] myArray = CalculateTimeDifference(userInput, now);
            Console.WriteLine($"There are {myArray[0]} days to go.");
            exit = CheckIfUserWantsToExit();
        }
        else if (userInput < now)
        {
            int[] myArray = CalculateTimeDifference(userInput, now);
            Console.WriteLine($"There are {myArray[0]} days past.");
            exit = CheckIfUserWantsToExit();
        }
        else
        {
            int[] myArray = CalculateTimeDifference(userInput, now);
            Console.WriteLine($"You entered Todays Date");
            exit = CheckIfUserWantsToExit();
        }
    }
    else
    {
        Console.WriteLine(
            "Invalid date format. Please enter the date in the correct format (e.g., 2024-06-20)."
        );
        exit = false;
    }
}

Console.WriteLine("Current date" + now.ToString("d"));

static bool CheckIfUserWantsToExit()
{
    Console.WriteLine("Do you want to exit [Y/N]?");
    string prompt = Console.ReadLine().Trim().ToUpper();

    if (prompt == "Y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

static int[] CalculateTimeDifference(DateTime userInput, DateTime now)
{
    TimeSpan timeDifference;
    if (userInput > now)
    {
        timeDifference = userInput - now;
    }
    else if (userInput < now)
    {
        timeDifference = now - userInput;
    }
    else
    {
        timeDifference = now - userInput;
    }

    int days = timeDifference.Days;
    int hours = timeDifference.Hours;
    int minutes = timeDifference.Minutes;
    int seconds = timeDifference.Seconds;

    int[] timeArray = new int[] { days, hours, minutes, seconds };
    return timeArray;
}

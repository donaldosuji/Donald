using System;
using System.Text.RegularExpressions;

class Program
{
    public static string ReverseDateFormat(string dateInput, TimeSpan timeout)
    {
        string pattern = @"^(?<mon>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})$";

        Regex regex = new Regex(pattern, RegexOptions.None, timeout);

        try
        {
            Match match = regex.Match(dateInput);

            if (match.Success)
            {
                string month = match.Groups["mon"].Value.PadLeft(2, '0');
                string day = match.Groups["day"].Value.PadLeft(2, '0');
                string year = match.Groups["year"].Value;

                if (year.Length == 2)
                {
                    year = "19" + year;
                }

                return $"{year}-{month}-{day}";
            }
            else
            {
                return "Invalid date format.";
            }
        }
        catch (RegexMatchTimeoutException)
        {
            return "Regex operation timed out.";
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a date in the format mm/dd/yyyy (or type 'exit' to quit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            if (DateTime.TryParse(input, out _))
            {
                TimeSpan timeout = TimeSpan.FromSeconds(1);
                string result = ReverseDateFormat(input, timeout);
                Console.WriteLine("Converted Date: " + result);
            }
            else
            {
                Console.WriteLine("Invalid date format. Please try again.");
            }
        }
    }
}

// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
DateTime currentDateTime = DateTime.Now;

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
DateTime TodayDateTime = DateTime.Today;

// TODO: DateOnly and TimeOnly represent just dates and times
DateOnly date = new DateOnly(2008, 04, 30);
TimeOnly time = new TimeOnly(03, 03, 20, 678);

// TODO: Dates have properties that can be inspected
Console.WriteLine("Day: " + date.Day);
Console.WriteLine("Month: " + date.Month);
Console.WriteLine("Year: " + date.Year);

Console.WriteLine("Hour: " + time.Hour);
Console.WriteLine("Minute: " + time.Minute);
Console.WriteLine("Second: " + time.Second);
Console.WriteLine("Millisecond: " + time.Millisecond);

// TODO: Dates also have methods to change their values
Console.WriteLine("Today's date and time plus 2 days: " + TodayDateTime.AddDays(2));
Console.WriteLine("Today's date and time plus 6 hours: " + TodayDateTime.AddHours(6));
Console.WriteLine("Today's date and time plus 20 minutes: " + TodayDateTime.AddMinutes(20));
Console.WriteLine("Today's date and time plus 13 seconds: " + TodayDateTime.AddSeconds(13));

// TODO: The TimeSpan class represents a duration of time
TimeSpan duration = new TimeSpan(1, 2, 3, 4, 500);
Console.WriteLine("TimeSpan duration: " + duration);

DateTime now = DateTime.Now;
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);

// TODO: Dates can be compared using regular operators
if (AprilFools > NewYears)
{
    Console.WriteLine("April Fools' Day is after New Year's Day.");
}
else if (AprilFools < NewYears)
{
    Console.WriteLine("April Fools' Day is before New Year's Day.");
}
else
{
    Console.WriteLine("April Fools' Day and New Year's Day are on the same date.");
}

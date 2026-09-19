namespace AcademyScheduleAnalyzer;

class Program
{
    static void Main(string[] args)
    {
        #region Part1

        string[] sessionNames = {
            "C# Basics",
            "Arrays",
            "Functions",
            "Date and Time",
            "Exception Handling"
        };
        DateTime[] sessionDates = {
            new DateTime(2026, 9, 10, 18, 0, 0),
            new DateTime(2026, 9, 13, 18, 0, 0),
            new DateTime(2026, 9, 17, 18, 0, 0),
            new DateTime(2026, 9, 20, 18, 0, 0),
            new DateTime(2026, 9, 24, 18, 0, 0)
        };
        
        int[] sessionDurations = {
            180,
            240,
            180,
            240,
            180
        };

        // for (int i = 0; i < sessionNames.Length; i++)
        // {
        //     Console.WriteLine($"Session : {sessionNames[i]}");
        //     Console.WriteLine($"Start : {sessionDates[i]}");
        //     Console.WriteLine($"Duration : {sessionDurations[i]}");
        //     Console.WriteLine("---------------------------------------------------------");
        //                 
        // }
        #endregion
        
        #region Part2
        
        // DisplaySchedule(sessionNames, sessionDates, sessionDurations);
        
        #endregion

        #region part 3

        SearchSessionName("Functions" ,  sessionNames, sessionDates, sessionDurations);

        #endregion
    }

    public static void DisplaySchedule(string [] names , DateTime [] dates, int [] durations)
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{i+1}. {names[i]}");
            Console.WriteLine($"Date : {dates[i].ToString("dd MMMM yyyy")}");
            Console.WriteLine($"Start Time: {dates[i].ToString("hh:mm tt")}");
            Console.WriteLine($"Duration: {durations[i]} minutes");
        }
    }  

    public static void SearchSessionName(string name, string[] names, DateTime[] dates, int[] durations)
    {
        int index = Array.IndexOf(names, name);
        if (index == -1)
        {
            Console.WriteLine("Session not found.");
            return;
        }
        Console.WriteLine($"{index+1}. {names[index]}");
        Console.WriteLine($"Date : {dates[index].ToString("dd MMMM yyyy")}");
        Console.WriteLine($"Start Time: {dates[index].ToString("hh:mm tt")}");
        Console.WriteLine($"Duration: {durations[index]} minutes");
    }
}
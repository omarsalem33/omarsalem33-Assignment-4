using System.Text;

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
        
        int[] sessionDurations = { 180, 240, 180, 240, 180 };

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

        // SearchSessionName("Functions" ,  sessionNames, sessionDates, sessionDurations);

        #endregion
        
        #region part 4
        // Console.WriteLine("=================Sorting Session Names=======================");
        // SortSessionNames(sessionNames);
        // Console.WriteLine("=======================Reverse Session Names=======================");
        // ReverseSessionNames(sessionNames);
        // Console.WriteLine("=======================Find Session Index=======================");
        // Console.WriteLine("Enter Session Name");
        // string name = Console.ReadLine();
        // FindSessionIndexByName(sessionNames, name);
        // Console.WriteLine("=======================Check if a Session Exists=======================");
        // CheckSessionExists(sessionNames, name);
        //
        // Console.WriteLine("=======================Find a Session=======================");
        // Console.Write("Enter Session Name: ");
        // string sessionName = Console.ReadLine();
        // if (Array.Find(sessionNames, x => x.Equals(sessionName)) == null)
        //     Console.WriteLine(sessionName +" not found.");
        // else
        //     Console.WriteLine(sessionName +" is found.");
        //
        // Console.WriteLine("=======================Find a Session Index Using a Condition=======================");
        // Console.Write("Enter Session Name: ");
        // string sessionNameyIndex = Console.ReadLine();
        // if (Array.FindIndex(sessionNames, x => x.Equals(sessionNameyIndex)) == -1)
        //     Console.WriteLine(-1);
        // else
        //     Console.WriteLine(Array.FindIndex(sessionNames, x => x.Equals(sessionNameyIndex)));
        //
        // Console.WriteLine("=======================Copy an Array=======================");
        // string []sessionCopy = new string [sessionNames.Length];
        // Array.Copy(sessionNames, sessionCopy, sessionNames.Length);
        // sessionCopy[0] = "Binary Search";
        // Console.WriteLine("1- Original Session Name ");
        // foreach (var session in sessionNames)
        // {
        //     Console.WriteLine(session);
        // }
        //
        // Console.WriteLine("2- Copy Session Name ");
        // foreach (var session in sessionCopy)
        // {
        //     Console.WriteLine(session);
        // }
        #endregion

        #region Part 5

        // Console.WriteLine("==============================Part 5 ==================================");
        //
        // Console.WriteLine($"Total Duration: {CalculateTotalDuration(sessionDurations)}");
        // Console.WriteLine($"Average Duration: {CalculateAverageDuration(sessionDurations)}");
        // Console.WriteLine($"Shortest Duration: {ShortestDuration(sessionDurations)}");
        // Console.WriteLine($"Longest Duration: {LargestDuration(sessionDurations)}");
        //
        // int [] durationsCopy = new int[sessionDurations.Length];
        // Array.Copy(sessionDurations,durationsCopy,sessionDurations.Length);
        // Array.Sort(durationsCopy);
        // Console.WriteLine("Duration Session after Sorting");
        // foreach (var durationSession in durationsCopy)
        //     Console.WriteLine(durationSession);    
        //

        #endregion
        
        #region part 6

        // Console.Write("enter a date");
        // string date = Console.ReadLine();
        // ReadSessionDate(date);
        //
        // string stringReport = BuildReportUsingString(sessionNames, sessionDates, sessionDurations);
        // Console.WriteLine("=== Report Built Using String ===");
        // Console.WriteLine(stringReport);
        //
        // string sbReport = BuildReportUsingStringBuilder(sessionNames, sessionDates, sessionDurations);
        // Console.WriteLine("=== Report Built Using StringBuilder ===");
        // Console.WriteLine(sbReport);

        #endregion
        
        #region part 7

        int x = 5;
        // Increment(ref x);
        // Console.WriteLine($"X in ref keyword: {x}");
        // int res;
        // Decrement(x, out res);
        // Console.WriteLine($"X in out keyword: {res}");
        //
        // Console.Write("Enter session: ");
        // string name = Console.ReadLine();
        // GetIndexAndDuration(sessionNames, sessionDurations, name, out int i , out int d);
        
        int[] originalArray = { 10, 20, 30, 40, 50 };

        Console.WriteLine("--- Before Function Call ---");
        DisplayArray(originalArray);

        ModifyArrayElement(originalArray, index: 2, newValue: 555);

        Console.WriteLine("\n--- After Function Call ---");
        DisplayArray(originalArray);
        
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
    public static void SortSessionNames(string[] sessionNames)
    {
        string[] sessionNamesCopy = new string [sessionNames.Length];
        Array.Copy(sessionNames, sessionNamesCopy, sessionNames.Length);
        Array.Sort(sessionNamesCopy);
        foreach (var name in sessionNamesCopy)
            Console.WriteLine(name);   
    }
    public static void ReverseSessionNames(string[] sessionNames)
    {
        string[] sessionNamesCopy = new string [sessionNames.Length];
        Array.Copy(sessionNames, sessionNamesCopy, sessionNames.Length);
        Array.Reverse(sessionNamesCopy);
        foreach (var name in sessionNamesCopy)
            Console.WriteLine(name);   
    }
    public static void FindSessionIndexByName(string[] sessionNames, string name)
    {
        Console.WriteLine($"Index :{Array.IndexOf(sessionNames, name)}");
    }
    public static void CheckSessionExists(string[] sessionNames, string name)
    {
        Console.WriteLine(Array.Exists(sessionNames, x => x.Equals(name))?"Session exists.":"Session does not exist.");
    }
    public static int CalculateTotalDuration(int [] durations)
    {
        int totalDuration = 0;
        foreach (var sessionDuration in durations)
        {
            totalDuration += sessionDuration;
        }
        return totalDuration;
    }
    public static int CalculateAverageDuration(int[] durations)
        => CalculateTotalDuration(durations) /  durations.Length;
    public static int ShortestDuration(int[] durations)
    {
        int shortestDuration = durations[0];
        for (int i = 0; i < durations.Length; i++)
        {
            if(durations[i] > shortestDuration)
                shortestDuration = durations[i];
        }
        return shortestDuration;
    }
    public static int LargestDuration(int[] durations)
    {
        int largesDuration = durations[0];
        for (int i = 0; i < durations.Length; i++)
        {
            if(durations[i] < largesDuration)
                largesDuration = durations[i];
        }
        return largesDuration;
    }
    public static DateTime ReadSessionDate(string date)
    {
        DateTime result;
        while (!DateTime.TryParse(date, out  result))
        {
            Console.Write("Invalid date format. Please enter a valid date (e.g., 2026-09-10 18:00): ");
            date = Console.ReadLine();
        }

        return result;
    }
    public static string BuildReportUsingString(string[] sessionNames, DateTime[] dates, int[] durations)
    {
        string report = "Session Name".PadRight(22) + "date".PadRight(20) + "Duration (min) \n";
        report += "--------------------------------------------------------------------------- \n";
        for (int i = 0; i < sessionNames.Length; i++)
        {
            report += sessionNames[i].PadRight(22)
                + dates[i].ToString("yyyy-MM-dd HH:mm").PadRight(20)
                + durations[i] + "\n";
        }
        return report;
    }
    public static string BuildReportUsingStringBuilder(string[] sessionNames, DateTime[] dates, int[] durations)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Session Name".PadRight(22) + "Date".PadRight(20) + "Duration (mins)");
        sb.AppendLine("------------------------------------------------------------------ \n");

        for (int i = 0; i < sessionNames.Length; i++)
        {
            sb.Append(sessionNames[i].PadRight(22));
            sb.Append(dates[i].ToString("yyyy-MM-dd HH:mm").PadRight(20));
            sb.AppendLine(durations[i].ToString());
        }

        return sb.ToString();
    }
    public static void Increment(ref int number)
    {
        number++;
    }
    public static void Decrement(int number, out int res)
    {
        res = --number;
    }
    public static void GetIndexAndDuration(string[] sessionNames,int []durations, string name,out int i, out int d)
    {
      
        i = sessionNames.IndexOf(name);
        d = durations[i];
        Console.WriteLine($"Index: {i}");
        Console.WriteLine($"Duration:  {d} minutes");
        
    }
    public static void ModifyArrayElement(int[] array, int index, int newValue)
    {
        if (array != null && index >= 0 && index < array.Length)
        {
            array[index] = newValue; 
        }
    }
    public static void DisplayArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}

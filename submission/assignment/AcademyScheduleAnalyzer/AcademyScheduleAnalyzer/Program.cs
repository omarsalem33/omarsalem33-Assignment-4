using System.Globalization;
using System.Text;
using BenchmarkDotNet.Running;

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
        
        int[] sessionDurations = {180, 240, 180, 240, 180 };

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

        // int x = 5;
        // Increment(ref x);
        // Console.WriteLine($"X in ref keyword: {x}");
        // int res;
        // Decrement(x, out res);
        // Console.WriteLine($"X in out keyword: {res}");
        //
        // Console.Write("Enter session: ");
        // string name = Console.ReadLine();
        // GetIndexAndDuration(sessionNames, sessionDurations, name, out int i , out int d);
        
        // int[] originalArray = { 10, 20, 30, 40, 50 };
        //
        // Console.WriteLine("--- Before Function Call ---");
        // DisplayArray(originalArray);
        //
        // ModifyArrayElement(originalArray, index: 2, newValue: 555);
        //
        // Console.WriteLine("\n--- After Function Call ---");
        // DisplayArray(originalArray);
        
        #endregion
        
        #region part 8
        // CalculateTotalDurationUsingParams(120, 180);
        // CalculateTotalDurationUsingParams(120, 180, 240);
        // CalculateTotalDurationUsingParams(60, 90, 120, 180, 240);
        #endregion

        #region Part 9

        // Console.Write("Enter a Session Name: ");
        // string sessionName = Console.ReadLine();
        // int index =  Array.IndexOf(sessionNames, sessionName);
        //
        // Console.WriteLine($"Date: {sessionDates[index]:dd MMMM yyyy}");
        // Console.WriteLine($"Day: {sessionDates[index].DayOfWeek}");
        // Console.WriteLine($"Year: {sessionDates[index].Year}");
        // Console.WriteLine($"Month: {sessionDates[index].Month}");
        // Console.WriteLine($"Day Number: {sessionDates[index].Day}");
        // Console.WriteLine($"Start Time: {sessionDates[index]:hh:mm tt}");
        // Console.WriteLine($"Duration: {sessionDurations[index]} minutes");
        // Console.WriteLine($"End Time: {sessionDates[index].AddMinutes(sessionDurations[index]):hh:mm tt}");

        #endregion

        #region Part 10

        // Console.Write($"First Session Name: ");
        // string firstSessionName = Console.ReadLine();
        // Console.Write($"Second Session Name: ");
        // string secondSessionName = Console.ReadLine();
        // int indexFirstSession = Array.IndexOf(sessionNames, firstSessionName);
        // int indexSecondSession = Array.IndexOf(sessionNames, secondSessionName);
        //
        // TimeSpan diff =sessionDates[indexFirstSession] - sessionDates[indexSecondSession];
        // diff = diff.Duration();
        // Console.WriteLine($"First Session:  {firstSessionName}");
        // Console.WriteLine($"First Session:  {secondSessionName}");
        // Console.WriteLine("Difference ");
        // Console.WriteLine($"{(int) diff.TotalDays} days");
        // Console.WriteLine($"{(int) diff.TotalHours} hours ");
        
        #endregion
        
        #region part 11
        // for (int i = 0; i < sessionNames.Length; i++)
        // {
        //     if (sessionDates[i] > DateTime.Now)
        //         Console.WriteLine($"{sessionNames[i]} Upcoming");
        //     else
        //         Console.WriteLine($"{sessionNames[i]} Past");
        // }
        #endregion 
        
        #region part 12
            // FindtheNextSession(sessionNames, sessionDates);
        #endregion
        
        #region part 13
        // DateFormating(sessionDates[0]);
        #endregion
        
        #region part 14

        // Console.Write("Enter date: ");
        // string dateInput = Console.ReadLine();
        // string[] format = { "dd-MM-yyyy", "dd/MM/yyyy", "yyyy/MM/dd", "yyyy-MM-dd" };
        // if (DateTime.TryParseExact(dateInput, format, CultureInfo.InvariantCulture, DateTimeStyles.None,
        //         out DateTime parsedDate))
        //     Console.WriteLine($"date is valid {parsedDate}");
        // else
        //     Console.WriteLine("date is not valid");

        #endregion

        #region Part 15
        // GetValidInteger();
        #endregion

        #region part16

        // GetSessionNameByUsingIndex(sessionNames);

        #endregion

        #region Part17

        // ValidatesASessionDuration();

        #endregion

        #region Part18
        // ValidatesASessionDuration();
        #endregion

        #region Part 19

        // Console.WriteLine(GeneratesScheduleReport(sessionNames, sessionDates, sessionDurations));

        #endregion
        
        #region Part20
        // Console.WriteLine(GeneratesScheduleReportUsingStringBuilder(sessionNames, sessionDates, sessionDurations));
        #endregion

        #region Part 21

        // BenchmarkRunner.Run<StringBenchmarks>();

        #endregion

        #region Part 22

        BenchmarkRunner.Run<StringBenchmarks>();

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
    public static void CalculateTotalDurationUsingParams(params int[] durations)
    {
        int total = 0;
        foreach (var duration in durations)
            total += duration;
        Console.WriteLine($"Total duration: {total}");
    }
    public static void FindtheNextSession(string[] sessionNames, DateTime[] dates)
    {
        Console.WriteLine("Next Session: ");
        for (int i = 0; i < sessionNames.Length; i++)
        {
            if (dates[i] >= DateTime.Now)
            {
                Console.WriteLine(sessionNames[i]);
                Console.WriteLine(dates[i].ToString("yyyy-MM-dd"));
                Console.WriteLine(dates[i].ToString("hh:mm t"));
                Console.WriteLine("TIme Remaining: ");
                TimeSpan diff = dates[i] - DateTime.Now;
                Console.WriteLine($"{diff.Days} days");
                Console.WriteLine($"{diff.Hours} hours");
            }
        }
    }
    public static void DateFormating(DateTime date)
    {
        Console.WriteLine(date.ToString("yyyy-MM-dd"));
        Console.WriteLine(date.ToString("dd/MM/yyyy"));
        Console.WriteLine(date.ToString("dd MMMM yyyy"));
        Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
        Console.WriteLine(date.ToString("h:mm tt "));
    }
    public static int GetValidInteger()
    {
        while (true)
        {
            Console.Write("Choose an Option:");
            string input = Console.ReadLine();
            try
            {
                int num = int.Parse(input);
                return num;
            }
            catch (FormatException )
            {
                Console.WriteLine("Invalid menu option. Enter a number");
            }
        }
    }
    public static void GetSessionNameByUsingIndex(string []sessionNames)
    {
        Console.Write("Enter Session Index: ");
        int index = int.Parse(Console.ReadLine());

        try
        {
            Console.WriteLine($"Session: {sessionNames[index]} ");
        }
        catch (IndexOutOfRangeException )
        {
            Console.WriteLine("The selected session index is out of range.");
           
        }
        
    }
    public static void ValidatesASessionDuration()
    {
        Console.Write("Enter Duration: ");
        int duration = int.Parse(Console.ReadLine());
        
        if (duration > 0)
            Console.WriteLine("Duration accepted");

        try
        {
            if (duration < 1)
                throw new ArgumentException();
        }
        catch (Exception e)
        {
            Console.WriteLine("Duration must be greater than zero");
        }
        finally
        {
            Console.WriteLine("Input operation finished");
        }
    }
    public static string GeneratesScheduleReport(string [] names, DateTime[] dates, int[] durations)
    {
        string result = "";

        for (int i = 0; i < names.Length; i++)
            result += $"{names[i]} - {dates[i]} - {durations[i]} \n";
        
        return result;
    }
    public static StringBuilder GeneratesScheduleReportUsingStringBuilder(string [] names, DateTime[] dates, int[] durations)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < names.Length; i++)
            result.Append( $"{names[i]} - {dates[i]} - {durations[i]} \n");
        
        return result;
    }
    
}

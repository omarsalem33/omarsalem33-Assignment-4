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
        
        #region part 4


        Console.WriteLine("=================Sorting Session Names=======================");
        SortSessionNames(sessionNames);
        Console.WriteLine("=======================Reverse Session Names=======================");
        ReverseSessionNames(sessionNames);
        Console.WriteLine("=======================Find Session Index=======================");
        Console.WriteLine("Enter Session Name");
        string name = Console.ReadLine();
        FindSessionIndexByName(sessionNames, name);
        Console.WriteLine("=======================Check if a Session Exists=======================");
        CheckSessionExists(sessionNames, name);
        
        Console.WriteLine("=======================Find a Session=======================");
        Console.Write("Enter Session Name: ");
        string sessionName = Console.ReadLine();
        if (Array.Find(sessionNames, x => x.Equals(sessionName)) == null)
            Console.WriteLine(sessionName +" not found.");
        else
            Console.WriteLine(sessionName +" is found.");
        
        Console.WriteLine("=======================Find a Session Index Using a Condition=======================");
        Console.Write("Enter Session Name: ");
        string sessionNameyIndex = Console.ReadLine();
        if (Array.FindIndex(sessionNames, x => x.Equals(sessionNameyIndex)) == -1)
            Console.WriteLine(-1);
        else
            Console.WriteLine(Array.FindIndex(sessionNames, x => x.Equals(sessionNameyIndex)));
        
        Console.WriteLine("=======================Copy an Array=======================");
        string []sessionCopy = new string [sessionNames.Length];
        Array.Copy(sessionNames, sessionCopy, sessionNames.Length);
        sessionCopy[0] = "Binary Search";
        Console.WriteLine("1- Original Session Name ");
        foreach (var session in sessionNames)
        {
            Console.WriteLine(session);
        }
        
        Console.WriteLine("2- Copy Session Name ");
        foreach (var session in sessionCopy)
        {
            Console.WriteLine(sessionCopy);
        }




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
    
}

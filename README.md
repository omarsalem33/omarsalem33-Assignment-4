# omarsalem33-Assignment-4
Assignment repo for assignment/1-4 (Assignment 4)
# Academy Schedule Analyzer

A C# console application for managing and analyzing an academy training schedule.

The project demonstrates practical use of **C# arrays, methods, DateTime, exception handling, ref/out parameters, params, string formatting, StringBuilder, and array operations**.

## Project Overview

The application stores information about academy sessions including:

- Session names
- Session dates and start times
- Session durations
- Searching and sorting sessions
- Duration calculations
- Date validation and formatting
- Upcoming session detection
- Input validation
- Report generation

The project is organized into multiple parts, with each part demonstrating a specific C# concept.

## Technologies Used

- C#
- .NET
- Console Application
- `System`
- `System.Globalization`
- `System.Text`

## Session Data

The application currently contains the following sessions:

| Session | Date | Duration |
|---|---|---:|
| C# Basics | September 10, 2026 - 18:00 | 180 minutes |
| Arrays | September 13, 2026 - 18:00 | 240 minutes |
| Functions | September 17, 2026 - 18:00 | 180 minutes |
| Date and Time | September 20, 2026 - 18:00 | 240 minutes |
| Exception Handling | September 24, 2026 - 18:00 | 180 minutes |

## Main Concepts Demonstrated

### 1. Arrays

The project uses parallel arrays to store session information:

```csharp
string[] sessionNames;
DateTime[] sessionDates;
int[] sessionDurations;
```

These arrays are used together to represent each academy session.

### 2. Displaying the Schedule

`DisplaySchedule()` loops through the arrays and displays each session with its date, start time, and duration.

### 3. Searching

The project demonstrates several ways to search arrays:

- `Array.IndexOf()`
- `Array.Exists()`
- `Array.Find()`
- `Array.FindIndex()`

Example:

```csharp
int index = Array.IndexOf(names, name);
```

### 4. Sorting and Reversing

The project demonstrates:

```csharp
Array.Sort();
Array.Reverse();
Array.Copy();
```

Copies are created before sorting or reversing so the original session-name array can remain unchanged.

### 5. Duration Calculations

The application includes methods for:

- Calculating total duration
- Calculating average duration
- Finding the shortest duration
- Finding the longest duration

> Note: The current implementation of `ShortestDuration()` and `LargestDuration()` contains comparison logic that should be reviewed if these methods are enabled.

### 6. Date and Time

The project uses `DateTime` to work with session dates and times.

Examples include:

```csharp
dates[i].ToString("dd MMMM yyyy");
dates[i].AddMinutes(durations[i]);
dates[i].DayOfWeek;
dates[i].Year;
dates[i].Month;
dates[i].Day;
```

### 7. Date Validation

The application demonstrates parsing dates with:

```csharp
DateTime.TryParse()
```

It also demonstrates exact-format validation with:

```csharp
DateTime.TryParseExact()
```

Supported examples include:

- `dd-MM-yyyy`
- `dd/MM/yyyy`
- `yyyy/MM/dd`
- `yyyy-MM-dd`

### 8. String and StringBuilder

Two approaches are demonstrated for generating reports:

```csharp
BuildReportUsingString()
```

and:

```csharp
BuildReportUsingStringBuilder()
```

`StringBuilder` is used to build the report efficiently.

### 9. `ref` and `out`

The project demonstrates both parameter modifiers.

Example:

```csharp
public static void Increment(ref int number)
{
    number++;
}
```

and:

```csharp
public static void Decrement(int number, out int res)
{
    res = --number;
}
```

### 10. `params`

The project includes a method that accepts a variable number of integer arguments:

```csharp
public static void CalculateTotalDurationUsingParams(params int[] durations)
```

This allows calls such as:

```csharp
CalculateTotalDurationUsingParams(120, 180);
CalculateTotalDurationUsingParams(120, 180, 240);
CalculateTotalDurationUsingParams(60, 90, 120, 180, 240);
```

### 11. Exception Handling

The project demonstrates exception handling using:

- `try`
- `catch`
- `finally`
- `FormatException`
- `IndexOutOfRangeException`
- `ArgumentException`

Example:

```csharp
try
{
    // Operation
}
catch (Exception e)
{
    // Handle error
}
finally
{
    // Final operation
}
```

## Project Structure

```text
AcademyScheduleAnalyzer/
│
├── Program.cs
└── README.md
```

## How to Run

### 1. Clone the repository

```bash
git clone <your-repository-url>
```

### 2. Open the project

Open the project using:

- Visual Studio
- Visual Studio Code
- JetBrains Rider

### 3. Run the application

Using the .NET CLI:

```bash
dotnet run
```

## Learning Objectives

By completing and studying this project, you can practice:

- Working with arrays
- Passing arrays to methods
- Searching arrays
- Sorting and reversing arrays
- Copying arrays
- Creating reusable methods
- Working with `DateTime`
- Formatting dates and times
- Calculating `TimeSpan`
- Validating user input
- Handling exceptions
- Using `ref` and `out`
- Using `params`
- Building strings with `StringBuilder`
- Generating formatted console reports

## Important Notes

Some sections of the project are currently commented out inside `Program.cs`. They can be uncommented individually to test the corresponding functionality.

The currently active section generates a schedule report using `StringBuilder`.

## Author

**Omar Salem**

GitHub: [omarsalem33](https://github.com/omarsalem33)

## License

This project is intended for educational and learning purposes.

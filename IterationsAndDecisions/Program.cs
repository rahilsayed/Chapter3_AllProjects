using System.Linq.Expressions;

Console.WriteLine("*****Iterations and Decisions*****");

Type t = typeof(string);


ForLoopExample();
ForEachLoopExample();
LinqQueryOverInts();
WhileLoopExample();
DoWhileLoopExample();
IfElseExample();
IfElsePatternMatching();
IfElsePatternMatching();
IfElsePatternMatchingUpdatedInCSharp9();
SwitchExample();
SwitchOnStringExample();
SwitchOnEnumExample();
SwitchWithGoto();

// A basic for loop.
static void ForLoopExample()
{
    // Note! "i" is only visible within the scope of the for loop.
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Number is: {0} ", i);
    }
    // "i" is not visible here.
}

// Iterate array items using foreach.
static void ForEachLoopExample()
{
    string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
    foreach (string c in carTypes)
    {
        Console.WriteLine(c);
    }
    int[] myInts = { 10, 20, 30, 40 };
    foreach (int i in myInts)
    {
        Console.WriteLine(i);
    }
}

static void LinqQueryOverInts()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
    // LINQ query!
    var subset = from i in numbers where i < 10 select i;
    Console.Write("Values in subset: ");
    foreach (var i in subset)
    {
        Console.Write("{0} ", i);
    }
}

static void WhileLoopExample()
{
    string userIsDone = "";
    // Test on a lower-class copy of the string.
    while (userIsDone.ToLower() != "yes")
    {
        Console.WriteLine("In while loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
    }
}

static void DoWhileLoopExample()
{
    string userIsDone = "";
    do
    {
        Console.WriteLine("In do/while loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
    } while (userIsDone.ToLower() != "yes"); // Note the semicolon!
}


//Again, C and C++ programmers need to be aware that the old tricks of testing a condition for a value not
//equal to zero will not work in C#. Let’s say you want to see whether the string you are working with is longer
//than zero characters. You might be tempted to write this:
static void IfElseExample()
{
    // This is illegal, given that Length returns an int, not a bool.
    string stringData = "My textual data";
    //if (stringData.Length)
    //{
    //    Console.WriteLine("string is greater than 0 characters");
    //}
    // Legal, as this resolves to either true or false.
    if(stringData.Length > 0)
{
        Console.WriteLine("string is greater than 0 characters");
    }
    else
    {
        Console.WriteLine("string is not greater than 0 characters");
    }
    Console.WriteLine();
}

static void IfElsePatternMatching()
{
    Console.WriteLine("===If Else Pattern Matching ===");
    object testItem1 = 123;
    object testItem2 = "Hello";
    if (testItem1 is string myStringValue1)
    {
        Console.WriteLine($"{myStringValue1} is a string");
    }
    if (testItem1 is int myValue1)
    {
        Console.WriteLine($"{myValue1} is an int");
    }
    if (testItem2 is string myStringValue2)
    {
        Console.WriteLine($"{myStringValue2} is a string");
    }
    if (testItem2 is int myValue2)
    {
        Console.WriteLine($"{myValue2} is an int");
    }
    Console.WriteLine();
}

static void IfElsePatternMatchingUpdatedInCSharp9()
{
    Console.WriteLine("======= C# 9 If Else Pattern Matching Improvements =======");
    object testItem1 = 123;
    Type t = typeof(string);
    char c = 'f';
    //Type patterns
    if (t is Type)
    {
        Console.WriteLine($"{t} is a Type");
    }
    //Relational, Conjuctive, and Disjunctive patterns
    if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine($"{c} is a character");
    };
    //Parenthesized patterns
    if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
    {
        Console.WriteLine($"{c} is a character or separator");
    };
    //Negative patterns
    if (testItem1 is not string)
    {
        Console.WriteLine($"{testItem1} is not a string");
    }
    if (testItem1 is not null)
    {
        Console.WriteLine($"{testItem1} is not null");
    }

    // the conditional operator can be used onlyin assignment statements. The following code will result in the compiler error 
    //stringData.Length > 0 ? Console.WriteLine("string is greater than 0 characters") : Console.WriteLine("string is not greater than 0 characters");

    Console.WriteLine();
}

//Note: the && and || operators both “short-circuit” when necessary. this means that after a complex
//expression has been determined to be false, the remaining subexpressions will not be checked. if you require
//all expressions to be tested regardless, you can use the related & and | operators.

// Switch on a numerical value.
static void SwitchExample()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");
    string langChoice = Console.ReadLine();
    int  n = int.Parse(langChoice);
    switch (n)
    {
        case 1:
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        case 2:
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }
}

static void SwitchOnStringExample()
{
    Console.WriteLine("C# or VB");
    Console.Write("Please pick your language preference: ");
    string langChoice = Console.ReadLine();
    switch (langChoice.ToUpper())
    {
        case "C#":
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        case "VB":
            Console.WriteLine("VB: OOP, multithreading and more!");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }
}

static void SwitchOnEnumExample()
{
    Console.Write("Enter your favorite day of the week: ");
    DayOfWeek favDay;
    try
    {
        //syntax to take enum type input from console and parse it into enum and assign to favday
        favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Bad input!");
        return;
    }
    switch (favDay)
    {
        case DayOfWeek.Sunday:
            Console.WriteLine("Football!!");
            break;
        case DayOfWeek.Monday:
            Console.WriteLine("Another day, another dollar");
            break;
        case DayOfWeek.Tuesday:
            Console.WriteLine("At least it is not Monday");
            break;
        case DayOfWeek.Wednesday:
            Console.WriteLine("A fine day.");
            break;
        case DayOfWeek.Thursday:
            Console.WriteLine("Almost Friday...");
            break;
        case DayOfWeek.Friday:
            Console.WriteLine("Yes, Friday rules!");
            break;
        case DayOfWeek.Saturday:
            Console.WriteLine("Great day indeed.");
            break;

        //Note: if multiple cases producec same result, we can combine like this
        //case DayOfWeek.Saturday:
        //case DayOfWeek.Sunday:
        //    Console.WriteLine("It’s the weekend!");
        //    break;
    }
    Console.WriteLine();
}

//Not generally used as this is considered anti design pattern
static void SwitchWithGoto()
{
    var foo = 5;
    switch (foo)
    {
        case 1:
            //do something
            goto case 2;
        case 2:
            //do something else
            break;
        case 3:
            //yet another action
            goto default;
        default:
            //default action
            break;
    }
}

static void ExecutePatternMatchingSwitch()
{
    Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
    Console.Write("Please choose an option: ");
    string userChoice = Console.ReadLine();
    object choice;
    //This is a standard constant pattern switch statement to set up the example
    switch (userChoice)
    {
        case "1":
            choice = 5;
            break;
        case "2":
            choice = "Hi";
            break;
        case "3":
            choice = 2.5M;
            break;
        default:
            choice = 5;
            break;
    }
    //This is new the pattern matching switch statement
    switch (choice)
    {
        case int i:
            Console.WriteLine("Your choice is an integer.");
            break;
        case string s:
            Console.WriteLine("Your choice is a string.");
            break;
        case decimal d:
            Console.WriteLine("Your choice is a decimal.");
            break;
        default:
            Console.WriteLine("Your choice is something else");
            break;
    }
    Console.WriteLine();
}

static void ExecutePatternMatchingSwitchWithWhen()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");
    object langChoice = Console.ReadLine();
    var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;
    switch (choice)
    {
        case int i when i == 2:
        case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        case int i when i == 1:
        case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }
    Console.WriteLine();
}

static string FromRainbowClassic(string colorBand)
{
    switch (colorBand)
    {
        case "Red":
            return "#FF0000";
        case "Orange":
            return "#FF7F00";
        case "Yellow":
            return "#FFFF00";
        case "Green":
            return "#00FF00";
        case "Blue":
            return "#0000FF";
        case "Indigo":
            return "#4B0082";
        case "Violet":
            return "#9400D3";
        default:
            return "#FFFFFF";
    };

    //C#8 feature
    //static string FromRainbow(string colorBand)
    //{
    //    return colorBand switch
    //    {
    //        "Red" => "#FF0000",
    //        "Orange" => "#FF7F00",
    //        "Yellow" => "#FFFF00",
    //        "Green" => "#00FF00",
    //        "Blue" => "#0000FF",
    //        "Indigo" => "#4B0082",
    //        "Violet" => "#9400D3",
    //        _ => "#FFFFFF",
    //    };
}

//Switch expression with Tuples
static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins.",
        ("rock", "scissors") => "Rock wins.",
        ("paper", "rock") => "Paper wins.",
        ("paper", "scissors") => "Scissors wins.",
        ("scissors", "rock") => "Rock wins.",
        ("scissors", "paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}
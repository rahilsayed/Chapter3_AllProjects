using FunWithStructures;

Console.WriteLine("***** A First Look at Structures *****\n");
// Create an initial Point.
Point myPoint;
myPoint.X = 349;
myPoint.Y = 76;
myPoint.Display();
// Adjust the X and Y values.
myPoint.Increment();
myPoint.Display();

PointWithReadOnly p3 =
new PointWithReadOnly(50, 60, "Point w/RO");
p3.Display();


var s = new DisposableRefStruct(50, 60);
s.Display();
s.Dispose();

Console.ReadLine();








struct Point
{
    // Fields of the structure.
    public int X;
    public int Y;
    // Add 1 to the (X, Y) position.
    public void Increment()
    {
        X++; Y++;
    }
    // Subtract 1 from the (X, Y) position.
    public void Decrement()
    {
        X--; Y--;
    }
    // Display the current position.
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}

readonly struct ReadOnlyPoint
{
    // Fields of the structure.
    public int X { get; }
    public int Y { get; }
    // Display the current position and name.
    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
    public ReadOnlyPoint(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
}


//Here instead of making whole struct read-only, only the fields are made read-only
ref struct DisposableRefStruct
{
    public int X;
    public readonly int Y;
    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
    // A custom constructor.
    public DisposableRefStruct(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
        Console.WriteLine("Created!");
    }
    public void Dispose()
    {
        //clean up any resources here
        Console.WriteLine("Disposed!");
    }
}

//test
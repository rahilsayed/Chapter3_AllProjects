Console.WriteLine("***** Fun with type conversions *****");
short numb1 = 30000, numb2 = 30000;
// Explicitly cast the int into a short (and allow loss of data).
short answer = (short)Add(numb1, numb2);
Console.WriteLine("{0} + {1} = {2}",
numb1, numb2, answer);
NarrowingAttempt();
ProcessBytes();

Console.ReadLine();



static int Add(int x, int y)
{
    return x + y;
}
static void NarrowingAttempt()
{
    byte myByte = 0;
    int myInt = 200;
    // Explicitly cast the int into a byte (no loss of data).
    myByte = (byte)myInt;
    Console.WriteLine("Value of myByte: {0}", myByte);
}



// another compiler error! although valid narrowing, compiler still gives error as it overflows the bounds of this data type
//static void narrowingattempt()
//{
//    byte mybyte = 0;
//    int myint = 200;
//    mybyte = myint;
//    console.writeline("value of mybyte: {0}", mybyte);
//}

static void ProcessBytes()
{
    byte b1 = 100;
    byte b2 = 250;
    // This time, tell the compiler to add CIL code
    // to throw an exception if overflow/underflow
    // takes place.
    try
    {
        byte sum = checked((byte)Add(b1, b2));
        Console.WriteLine("sum = {0}", sum);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
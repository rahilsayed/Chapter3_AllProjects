Console.WriteLine("***** Fun with Methods *****\n");
// Pass two variables in by value.
int x = 9, y = 10;
Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
Console.WriteLine("Answer is: {0}", Add(x, y));
Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
Console.ReadLine();


static int AddWrapper(int x, int y)
{
    //Do some validation here
    return Add();
    int Add()
    {
        return x + y;
    }
}

static int AddWrapperWithSideEffect(int x, int y)
{
    //Do some validation here
    return Add();
    int Add()
    {
        x += 1;
        return x + y;
    }
}

static int AddWrapperWithStatic(int x, int y)
{
    //Do some validation here
    return Add(x, y);
    static int Add(int x, int y)
    {
        x += 1;
        return x + y;
    }
}

// Value type arguments are passed by value by default.
static int Add(int x, int y)
{
    int ans = x + y;
    // Caller will not see these changes
    // as you are modifying a copy of the
    // original data.
    x = 10000;
    y = 88888;
    return ans;
}
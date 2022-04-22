//1. Declare a C# base class that cannot be instantiated directly, but 
//must be overridden to create a class that can be instantiated. (2 points)

abstract class absClass{

    public abstract int getValue();
}

public class mainClass : absClass
{
    public override int getValue()
    {
        return 1;
    }
}
using System;

//3.Which is the correct approach to using an object that implements IDisposable in C#: (10 points)
//1.
//void DoSomething()
//{
//    var connection = new SqlConnection(ConnectionString);

//    // Use connection
//}

//2.
//void DoSomething()
//{
//    var connection = new SqlConnection(ConnectionString);

//    // Use connection

//    connection.Dispose();
//}

//3.
//void DoSomething()
//{
//    using (var connection = new SqlConnection(ConnectionString))
//    {
//        // Use connection
//    }
//}


namespace Finexio
{
    public void DoSomething()
    {
        using (var connection = new SqlConnection(ConnectionString))
        {
            // Use connection
            // This solution is better because all objects created inside the
            // using block will be disposeddisposal by its end.
        }
    }
}


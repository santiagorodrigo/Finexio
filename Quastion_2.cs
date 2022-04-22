//2.Alter this program to trap exceptions thrown from the DoSomething() method
//and log them to the TextWriter instance. (7 points)
//class Program
//{
//	private static TextWriter logFile = File.AppendText("log.txt");

//	static void Main(string[] args)
//	{
//		DoSomething();
//	}
//}


using System;
namespace Finexio
{
	public class Quastion_2
	{
		private static TextWriter logFile = File.AppendText("log.txt");

        static void Main(string[] args)
        {
            try
            {
                DoSomething();
            }
            catch (Exception ex)
            {
                logFile.WriteLine("Exception on Question_2.cs as :" + ex.Message);
            }
            
        }
    }
}


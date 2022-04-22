//5.The following function is supposed to return the largest of the 3 integers passed as parameters. Implement the test method to verify that this function works as expected. (8 points)
// int LargestOfThree(int num1, int num2, int num3);
//[TestMethod()]
//public void TestLargestOfThree()
//{
//}

using System;

namespace Finexio
{
	public class Question_5
	{
		int LargestOfThree(int num1, int num2, int num3);


    }

    [TestMethod()]
    public void TestLargestOfThree()
    {
        // Testing edge cases
        Assert.AreEqual(LargestOfThree(0, 0, 0), 0);

        // There are 9 possibilities
        Assert.AreEqual(LargestOfThree(1, 0, 0), 1);
        Assert.AreEqual(LargestOfThree(0, 1, 0), 1);
        Assert.AreEqual(LargestOfThree(0, 0, 1), 1);

        Assert.AreEqual(LargestOfThree(2, 1, 0), 2);
        Assert.AreEqual(LargestOfThree(1, 2, 1), 2);
        Assert.AreEqual(LargestOfThree(1, 0, 2), 2);

        Assert.AreEqual(LargestOfThree(1, 2, 3), 3);
        Assert.AreEqual(LargestOfThree(3, 1, 2), 3);
        Assert.AreEqual(LargestOfThree(2, 3, 1), 3);

    }

    
}


using System;

//4.What's wrong with this code? (5 points)
//// Walk up the item's parents, printing the name to the console
//void DoWalkThePath(Item item)
//{
//while (item != null)
//{
//Console.WriteLine(item.Name);
//}
//}

//class Item
//{
//    public string Name;
//    public Item Parent;
//}

//5.The following function is supposed to return the largest of the 3 integers passed as parameters. Implement the test method to verify that this function works as expected. (8 points)
// int LargestOfThree(int num1, int num2, int num3);
//[TestMethod()]
//public void TestLargestOfThree()
//{
//}


namespace Finexio
{
	public class Question_4
	{
		void DoWalkThePath(Item item)
        {
            while (item != null)
            // The problem is in this loop because it not goes to
            // next node. One solution could be assign Parent property to item
            {
                Console.WriteLine(item.Name);

                // item = item.Parent;

            }

            //or

            //using recursive way
            if (item != null)
            {
                Console.WriteLine(item.Name);
                DoWalkThePath(item.Parent);
            }

        }

        class Item
        {
            public string Name;
            public Item Parent;
        }
    }
}



using System.Collections;

namespace Console1.Lesson
{
    public class Chapter5
    {
        public Chapter5()
        {
            //Create ArrayList and assign value.
            //Method 1
#pragma warning disable IDE0028 // Simplify collection initialization
            ArrayList myArList1 = new();
#pragma warning restore IDE0028 // Simplify collection initialization
            myArList1.Add(1);
            myArList1.Add("A");
            myArList1.Add("B");
            myArList1.Add(0.12);
            myArList1.Add(true);

            //Method 2
            ArrayList myArList2 = new() { 2, "C", "D", 0.5, false ,"Hello"};

            //Show value Method 1
            Console.WriteLine($"Count of ArrayList = {myArList2.Count}");

            for (int i = 0; i < myArList2.Count; i++)
            {
                Console.WriteLine(myArList2[i]);
            }

        }

        public static void Testc()
        {
            Console.WriteLine("Static");
        }

        public static int Sum(int x,int y) 
        {
            return x + y;
        }

        //using a delegate with an attribute


       

    }



}

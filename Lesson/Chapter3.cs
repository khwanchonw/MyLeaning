//Lesson 3:Condition if else switch case nested if
namespace Console1.Lesson
{
    public class Chapter3
    {
        public Chapter3() //<<When create method that have same name as class name, it's called CONSTRUCTOR
        {
            Console.Write("Enter Condition Type (If Else Switch Case Nested) : " );
            var chr = Console.ReadLine();

            if (chr == "I")
                { Console.WriteLine("You enter a IF"); }
            else if (chr == "E")
                { Console.WriteLine("You enter a Else"); }
            else if (chr == "S")
                { Console.WriteLine("You enter a Swich");
                Swch();}//<<method that created for switch sample, 
            else { Console.WriteLine("You enter something else!"); }
        }
        
        //Sample for Swich
        public static void Swch() //<<This will create Swch() method.
        { Console.Write("Switch Day : ");
            var sw = Console.ReadLine();

            switch (sw)
            {
                case "1":
                    Console.WriteLine("You Select Day {0}",sw);
                    break;
                case "2":
                    Console.WriteLine("You Select Day {0}", sw);
                    break;
                default:
                    Console.WriteLine("Other Days");
                    break;
            }
        }
    }
}

        


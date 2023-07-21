namespace Console1
{
    public class Program1

    {
        public Program1()
        {
            Console.Write("Enter Angle (Decimal Degree) :");
            var S = Console.ReadLine() ?? "null";

            if (IsNumeric(S) && S!=null)
            {

            var D = Double.Parse(S);
                Console.WriteLine($"Radian is {D * Math.PI / 180}");
            }
            else
            {
            Console.WriteLine($"You not enter number");
            }
            
        }

        public static bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public static bool IsInteger(string value)
        {
            return value.All(char.IsNumber);
        }




    }
}

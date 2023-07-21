//Chapter 4: Loop for while do
namespace Console1.Lesson
{
    public class Chapter4
    {
        public Chapter4()
        {
        Console.WriteLine("This is Loop sample");
        Console.Write("Enter 1 to 10 : ");
        
        
        string input = Console.ReadLine() ?? "null"; //รับค่า input
        
            if (Program1.IsNumeric(value: input) == true && input!=null ) //ตรวจสอบค่า input ว่าเป็น number และ ไม่ใช่ null
            {
                int n = int.Parse(input);

                Console.WriteLine("\n\nfor sample");
                for (int i = 1; i<=10;++i)
                {
                    if(i==n) { Console.WriteLine(">>{0}<<",i); }
                    else
                    {
                    Console.WriteLine(i);
                    }
                }
            
                Console.WriteLine("\n\nwhile sample"); //check condition before loop
                int a = 1;
                while (a <= n)
                    {
                    Console.WriteLine(a);
                    a++;
                }

                Console.WriteLine("\n\ndo sample"); //loop before check condition
                int b = n;
                do {
                    Console.WriteLine(b);
                    b++;
                } while (b <= 10);


                Console.WriteLine("\n\nforeach sample"); //foreach sample
                string[] arr = {"A","B","C","D" }; //declare and assign value to array
                foreach (string i in arr)
                { Console.WriteLine($"for {i}"); }
                
            }
            else {Console.WriteLine("NOT NUMBER");}
        }

    }
}

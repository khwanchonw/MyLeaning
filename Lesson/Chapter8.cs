
namespace Console1.Lesson
{
    public class Chapter8
    {
        public Chapter8()
            {
            try
            {
                Console.Write("Enter Number : ");
                string? a = Console.ReadLine();
                int b = int.Parse(a ?? "null");
                Console.WriteLine(b + 5);
            }
            
            catch (Exception ex)
            {
                _ = new ExcepTest(ex);            
            }

            finally
            {
                Console.WriteLine("finally block.1");
                try
                {
                    using StreamReader sr = new("E:/Temp/test.txt/");
                    Console.WriteLine(sr.ReadToEnd());
                }
                catch (Exception ex) 
                {
                    _ = new ExcepTest(ex);
                    
                }
                finally { Console.WriteLine("finally block.2"); }


            }

        }
        public class ExcepTest
        {
            public ExcepTest(Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
            }
        }
    }


}

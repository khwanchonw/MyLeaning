using System.Globalization;

namespace Console1.Lesson
{
    public class Chapter6
    {
        public Chapter6() //Date Time
        {
            DateTime ThisTime = DateTime.Now;

            Console.WriteLine(ThisTime);

            DateTime date1 = new(2023,7,18,8,30,0);//create datetime
            Console.WriteLine(date1);
            
            TimeSpan timeSpan = new(6,30,0);//Timespan use for add to time[h,m,s] to datetime
            Console.WriteLine(date1.Add(timeSpan));//show datetime that added timespan
            Console.WriteLine(date1.AddDays(1.5));//add 1.5 day(mean 24h+12h)
            Console.WriteLine(date1.AddDays(-1.5));//- 1.5 day
            //or
            Console.WriteLine(date1.Subtract(timeSpan));//dif between date1 and timespan

            Console.WriteLine(date1.ToString("ddd-mmm-yyy"));
            Console.WriteLine(date1.ToString("dddd-mmmm-yyyy"));//about format see https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings

            CultureInfo cultureEN = new("en-EN");
            DateTime dateTimeEN = Convert.ToDateTime("10/22/2015 3:10:15 PM", cultureEN);
            Console.WriteLine(dateTimeEN);

            CultureInfo cultureTH = new("th-TH");
            DateTime dateTimeTH = Convert.ToDateTime("22/10/2566 3:10:15", cultureTH);//convert bc. to ac.
            Console.WriteLine(dateTimeTH);

            Console.WriteLine(ThisTime.ToString("ddd/MMM/yyyy HH:mm:ss",new CultureInfo("th-TH")));//date in thai, may not show correct in console


            //More Info at https://www.c-sharpcorner.com/article/datetime-in-c-sharp/

        }
       
        public static void Casting()
        {
            Console.Write("Enter Number : ");
            string? input = Console.ReadLine();//input from ReadLine alway return as string?
                      
            //Convert String to Double
            Double d1 = Convert.ToDouble(input);
            Console.WriteLine($"{d1} + 5 = {d1 + 5}");
            //OR
            Double d2 = double.Parse(input ?? "");
            Console.WriteLine($"{d2} + 10 = {d2 + 10}");

            //Covert Double to Interger16
            int i1 = Convert.ToInt16(d1);
            Console.WriteLine($"Int16 = {i1}");

            //Convert Double to String
            Console.WriteLine(Convert.ToString(d1));
            //Or
            string s1 = d1.ToString("0.000");
            Console.WriteLine(s1);

            Console.WriteLine(d1.ToString("00.0000"));
        }

 
        public static void FioCreate(string filepath,string value = "")
        {
            
            Console.WriteLine(value);

            //new StreamWriter(filepath).WriteLine("Test"); //This not auto close file or maybe delay
            //OR
            //System.IO.StreamWriter sw = new(filepath);
            //sw.WriteLine($"{value}");
            //sw.Close();
            // OR
            using (StreamWriter sw = new(filepath)) // using was used for makesure that resource will release. 
            {
            sw.WriteLine(value);
            }

            Console.WriteLine("Create File Completed.");
        }
            
        
        public static void FioRead(string filepath)
        {
            //Console.WriteLine(File.ReadAllText(filepath));

            //// Or
            //System.IO.StreamReader sr = new(filepath);
            //Console.WriteLine(sr.ReadToEnd());
            //sr.Close();

            //// OR
            using StreamReader sr = new(filepath); 
            Console.WriteLine(sr.ReadToEnd());


        }

        public static void FioAddStr(string filepath,string addstring) 
        {   
            File.AppendAllText(filepath, addstring + "\n");
            Console.WriteLine($"Add string : {addstring} <completed>");
        }

        


    }
}


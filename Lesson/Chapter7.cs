
namespace Console1.Lesson
{
    public class Humen
    {
        //Property
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Age { get; }

        //Constructor
        public Humen(string name, DateTime birthday)
        {
            Name = name; // when create instance of humen, constructor will get parameter and set it to property 
            Birthday = birthday;
            Age = Programs.TimeInterval(Birthday, DateTime.Now);
        }
    }

    public class Employee : Humen //Inherited from Humen Class
    {
        public DateTime Startdate { get; set; }
        public string Worktime { get;}
        public Employee(string name, DateTime birthday, DateTime startdate) : base(name, birthday)
        {
            Startdate = startdate;           
            Worktime = Programs.TimeInterval(startdate,DateTime.Now);
        }

        public static int StartWorkAge(DateTime birthday,DateTime startdate)
        {
            return (startdate - birthday).Days / 365;
        }
    }

    
    public class Programs
    {
        private static string ReturnStr(int[] ymd)
        {
            return $"{ymd[0]} year {ymd[1]} month {ymd[2]} day";
        }
        private static int[] TSA(TimeSpan period)// Convert TimeSpan to YearMonthDate as array
        {
            return new int[] { period.Days / 365, period.Days % 12, period.Days % 30 };
        }


        public static  string TimeInterval(TimeSpan interval) //Create Method for calculate time period between 2 datetime
        {
            return ReturnStr(TSA(interval));
        }

        public static  string TimeInterval(DateTime From, DateTime To)//Create more option 
        {
            TimeSpan interval = To - From;
            return ReturnStr(TSA(interval));
        }
 

    }


}

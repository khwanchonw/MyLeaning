using Console1;
using Console1.Lesson;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

//Chapter 3: Conditions.
//new Chapter3();
//Console.WriteLine("This is when call method Swch in Chapter3 : ");
//Chapter3.Swch();

//Chapter 5: ArrayList and annotation delegate.
//new Chapter5();
//Chapter5.Testc();


//Chapter 6: Date, Time, String, casting and using system.io to manage files.
//new Chapter6();
//Chapter6.Casting();
//string filepath = "E:/Temp/test.txt";
//string copy1 = "E:/Temp/testCopy.txt";
//string string1 = $"Test time at : {DateTime.Now}";
//Chapter6.FioCreate(filepath, $"{string1} <Create>");
//Chapter6.FioAddStr(filepath, $"{string1}");
//Chapter6.FioRead(filepath);
//Console.WriteLine(File.Exists(filepath));
//File.Delete(filepath);
//Console.WriteLine(File.Exists(filepath));
//File.Copy(filepath, copy1, true);

////Chapter 7: Object Oriented Programming (OOP)
//DateTime birthday = new(1977, 12, 29);
//DateTime startday = new(2018, 07, 01);
//DateTime now = DateTime.Now;
//Humen a = new("Peter",  birthday);
//Console.WriteLine("Birth Year of {0} is {1} ", a.Name, a.Birthday.Year);
//Console.WriteLine("");

//Employee b = new("John", birthday, startday);
//Console.WriteLine("Report time  : {0}",now);
//Console.WriteLine("Name         : {0}",b.Name);
//Console.WriteLine("Birth Date   : {0}",b.Birthday.ToString("yyyy-MM-dd"));
//Console.WriteLine("Age          : {0}",b.Age);
//Console.WriteLine("Start Work   : {0}",b.Startdate.ToString("yyyy-MM-dd"));
//Console.WriteLine("Work Period  : {0}",b.Worktime);
//Console.WriteLine("Age at Start : {0}",Employee.StartWorkAge(birthday, startday));
////Or
//string report =
//    $"\n--OR--\n"+
//    $"Report time   : {now}\n"+ //Check time output result
//    $"Name          : {b.Name}\n" +
//    $"Birth Date    : {b.Birthday:yyyy-MM-dd}\n" + //New short syntax for datetime format
//    $"Age           : {b.Age}\n"+
//    $"Start Work    : {b.Startdate:yyyy-MM-dd}\n"+
//    $"Work Period   : {b.Worktime}\n"+
//    $"Age at Start  : {Employee.StartWorkAge(birthday,startday)}\n"
//    ;
//report = report.Replace(":", "=");
//Console.WriteLine($"{report}") ;

//Chapter 8: data model and exeception.

//_ = new Chapter8();


//Chapter 9: Basic of api Restful get post put delete response code
//await Restful.Get();
//await Restful.Post();

//Test array of box
static void Array()
{

    Console.Write("\nEnter Esc to Exit : ");
    
    
    if (Console.ReadKey().Key == ConsoleKey.Escape)
    {
        Console.WriteLine("\nExit Program..");
    }
    else
    {
    Console.Write("\nEnter number of Column : ");
    int colume = Convert.ToInt16(Console.ReadLine());
    Console.Write("Enter number of Row : ");
    int row = Convert.ToInt16(Console.ReadLine());
    Console.Write("Enter Column's Spacing : ");
    int space = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("\nColume = {0} Row = {1} Spacing = {2}", colume, row,space);

    string s = string.Concat(Enumerable.Repeat(" ",space));

    for (int ii = 1; ii<= row;ii++ )
    {
        for (int i = 1;i <= colume;i++)
        {
            Console.Write("[ ]" + s);
        }
        Console.WriteLine();
    }

    Array();
    }
}

try
{
Array();
}
catch (Exception e) 
{ 
    Console.WriteLine(e.Message.ToString());
}









Console.ReadLine();


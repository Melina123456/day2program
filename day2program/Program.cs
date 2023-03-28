using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person Melina = new person();
         //   Melina.numberofeyes = 2;
            Melina.noofeyes = 3;
            Melina.haircolor = "black";
            Console.WriteLine("You have" + Melina.noofeyes + "eyes");
          //  Console.WriteLine("you have"+ Melina.numberofeyes+"eyes");
            Console.WriteLine("Your hair color is " + Melina.haircolor);
            //calling function from person.cs program
            Melina.EatingHabit();
            Melina.EatingHabit("Burger");
            string muLunch = Melina.EatHabit("Rice");
            Console.WriteLine(muLunch);
            Console.ReadKey();
          //  LogicalOperator();
          //  Console.ReadKey();
        }
        //This function is example of logical operator
        //static void LogicalOperator()
        //{
        //    Console.WriteLine("Enter your college name:");
        //    string CollegeName=Console.ReadLine();    
        //    Console.WriteLine("Enter your program");
        //    string programName=Console.ReadLine();
        //    if(string.IsNullOrEmpty(CollegeName))
        //    {
        //        Console.WriteLine("Please enter college name");
        //    }
        //    else if(CollegeName.ToUpper()=="BMC"&&programName.ToUpper()=="CSIT")
        //    {
        //        Console.WriteLine("Your are welcome in lab");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You may not enter.");
        //    }

        //}
    }
}

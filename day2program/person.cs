using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace day2program
{
    internal class person
    {
        int numberofeyes;
        public int noofeyes
        {
            get { return numberofeyes; }
            set { numberofeyes = value; }
        }
        public string haircolor
        {
            get; set;
        }
        public void EatingHabit()
        {
            Console.WriteLine("I usually have momo in lunch.");
        }
        public void EatingHabit(string myLunch )
        {
            Console.WriteLine("I usually have " + myLunch + " in lunch.");
        }
        public string EatHabit(string myLunch)
        {
            return "I usually have " + myLunch + " in my lunch";
        }
    }
}

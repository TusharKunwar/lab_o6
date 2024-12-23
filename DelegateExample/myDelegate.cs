using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    internal class myDelegate
    {
        public delegate void DisplayName(string yourName);
        public delegate void displayNoOfDays(int yourBirthYear);
    
    public static void NameDisplay(string Name)
        {
            Console.WriteLine("hello mr. " + Name);
        }
        public static void DaysDisplay(int year)
        {
            Console.WriteLine("your number of days " + (System.DateTime.Now.Year - year) * 365);
        }
        public void DelegateCall()
        {
            DisplayName dn = new DisplayName(myDelegate.NameDisplay);
            displayNoOfDays dnD = new displayNoOfDays(myDelegate.DaysDisplay);
            Console.ReadKey();
        }
    }
}
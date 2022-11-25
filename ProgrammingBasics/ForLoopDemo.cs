using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    public  class ForLoopDemo
    {
        //This class will be used to Practice For Loops
        /// <summary>
        /// starting pont, endingpoint or condition 
        /// </summary>
        //public static void SimpleLoopDemo()
        //{
        //    for(int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{i}");
        //    }

        //}
        public static void NameListDemo()
        {
            List<string> names = GetNames();

            for (int i = 0; i < names.Count(); i++)
            {
                Console.WriteLine($"{names[i]}");
            }


        }

        public static void ForeachNameListDemo()
        {
            string[] hh = { "whehr", "wewewe", "ewewe", "ewewe", "wewe" }; //size static 
            //list size => dynamic




            List<string> names = GetNames();
            foreach (string name in names)
            {
                Console.WriteLine($"{name}"); //Usman,Ali,Fahad,,,,,
            }
        }
        private static List<string> GetNames()
        {
            List<string> names = new List<string>();
            names.Add("Usmaan");
            names.Add("ALi");
            names.Add("Fahad");
            names.Add("Zohaib");
            names.Add("Ijaz");

          
            return names;

        }
    
    
       
    }
}

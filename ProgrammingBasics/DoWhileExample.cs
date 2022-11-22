using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    internal class DoWhileExample
    {
        public static void simpleDoWhileExample()
        {
            int i = 10;
            do
            {
                int choice = 0;
                Console.WriteLine("Press 1 to Go to Dashbaord");
                Console.Read();
                i = 11;
                
            }while (i == 10);
           
        }

        public static void DoWhileMenuExample()
        {
            //=> Game  =? 
            //    Press 1 to start;
            //    Press 22 to go to settings;
            //  if wrong entry show message you jhave entered wrong number..
            //    CompressedStack 3 to exit;


            do
            {
                Console.Clear();
                int choice = 0;
                Console.WriteLine("Press 1 to Start");
                Console.WriteLine("Press 2 to Show Settings");
                Console.WriteLine("Press 3 to Exit");

                Console.Write("Enter your Choice here:");
                try
                {
                      choice = Convert.ToInt32(Console.ReadLine());

                }catch (Exception ex)
                {
                    Console.WriteLine('C');
                    Console.WriteLine("Please Enter a valid number");
                }



                if (choice == 1)
                {
                    Console.WriteLine("Welcome to the Game");
                    
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Welcome to the Settings");
                }
                else if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Choice");
                }

                Console.ReadKey();

            } while (true);

 




            //int i = 10;
            //do
            //{
            //    int choice = 0;
            //    Console.WriteLine("Press 1 to Go to Dashbaord");
            //    Console.Read();
            //    i = 11;

            //} while (i == 10);

        }
    }
}

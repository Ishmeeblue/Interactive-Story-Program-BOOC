using System;

namespace Interactive_Story_Program_BOOC
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to this Interactive Story Game!");
            Console.Write("Before Starting the Story Please Input Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Alright! " + name + ", Are You Ready to Start?");
            Console.Write("Press 1 to Start , Press 2 to Exit: ");
            int FA = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            fA(FA, name);
        }
        public static void fA(int FA, string name)
        {
            switch (FA)
            {
                case 1:
                    StartStory.SS(name);
                    break;
                case 2:
                    Console.WriteLine("Closing..");
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Press 1 to Start or 2 to Exit.");
                    break;
            }
        }
    }
}
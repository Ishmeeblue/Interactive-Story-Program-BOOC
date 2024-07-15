using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Story_Program_BOOC
{
    internal class StartStory
    {
        public static void SS(string name)
        {
            Console.WriteLine("Loading...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("CHAPTER 1: Choked by Shadows");

            List<string> firstlist = new List<string>
    {
        $"We're done... I'm tired of you. I can't understand you anymore,{name}. You and your so-called DEPRESSION drain me too!",
        "My ear rang, and my world suddenly spun when I heard Avery say that.",
        "Please give me a chance to fix myself... I'm not myself anymore, Avery. I can't lose another part of me.",
        "I begged with no shame in the hallway, but Avery doesn't care anymore and walked away. I didn't know what to do...",
        "My important research defense that I worked hard for will start in 30 minutes... but Avery is the only one keeping me sane.",
    };

            foreach (string s in firstlist)
            {
                Console.WriteLine(s);
                Console.ReadKey();
            }
            Console.Write("Should I run to Avery and beg (1) or just let it go? (2): ");
            int SA = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            sA(SA, name);
        }

        public static void sA(int SA, string name)
        {
            switch (SA)
            {
                case 1:
                    List<string> secondlist = new List<string>
                    {
                   "I ran but Avery seems nowhere. I searched every corner for hours to try and fix us, leaving my research defense unattended",
                   "But it was all in vain. I didn't see Avery even a little. I was full of regrets... My self is being punished even more.",
                   "Losing Avery and securing another failure... my life seems useless even more... Mom, you're wrong. I can't live without you.",
                   "As I walk aimlessly, I decided to go... home (1) or at the convenience store (2)."
                    };
                    foreach (string s in secondlist)
                    {
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                    Console.Write("As I walk aimlessly, I decided to go... home (1) or at the convenience store (2): ");
                    int TA = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    tA(TA, SA, name);
                    break;
                case 2:
                    List<string> thirdlist = new List<string>
                    {
                    "I accepted the reality. I was not enough and was trapped in my own world of problems. I'm better off alone I guess",
                    "I forgot Avery and got eaten up by my anxiety and depression. How can I put aside someone so important to me?",
                    "As I get ready for my defense. My mind would just float away and my emotions drowned me. I was so out of it and messed up in my defense.",
                    "Losing Avery and securing another failure... my life seems useless even more... Mom, you're wrong.I can't live without you.",
                    };
                    foreach (string s in thirdlist)
                    {
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                    Console.Write("After unfortunate events. I decided to go... home (1) or at the convenience store (2): ");
                    int ThA = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    tHA(ThA, SA, name);
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Press 1 or 2.");
                    break;
            }
        }
        public static void tA(int TA, int SA, string name)
        {
            switch (TA)
            {
                case 1:
                    Home.sA1(SA, name);
                    break;
                case 2:
                    List<string> fourthlist = new List<string>
                    {
                    "I was tired searching around so I just thought of buying a drink before going home.",
                    };
                    foreach (string s in fourthlist)
                    {
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                    Console.Write("Hmmm... what should I drink? Beer (1) or Juice (2): ");
                    int drink = Convert.ToInt16(Console.ReadLine());
                    Drink(drink, SA, name);
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Press 1 or 2.");
                    break;
            }
        }
        public static void tHA(int ThA, int SA, string name)
        {
            switch (ThA)
            {
                case 1:
                    Home.sA1(SA, name);
                    break;
                case 2:
                    List<string> fifthlist = new List<string>
                    {
                    "I was frustated so I just thought of buying a drink before going home.",
                    };
                    foreach (string s in fifthlist)
                    {
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                    Console.Write("Hmmm... what should I drink? Beer (1) or Juice (2): ");
                    int drinkk = Convert.ToInt16(Console.ReadLine());
                    Drinkk(drinkk,SA, name);
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Press 1 or 2.");
                    break;
            }
        }
        public static void Drink(int drink, int SA, string name)
        {
            switch (drink)
            {
                case 1:
                    List<string> sixthlist = new List<string>
                    {
                    "I should get a beer maybe, something to help me calm on the way home.",
                    "Now I have my beer, I'll drink this while walking.",
                    "After 15 Minutes..."
                    };
                    foreach (string s in sixthlist)
                    {
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                    Console.Clear();
                    Home.sA1(SA, name);
                    break;
                case 2:
                    List<string> seventhlist = new List<string>
                    {
                    "Just juice maybe, just something to refresh me on the way home",
                    "Now I have my juice, I'll drink this while walking.",
                    "After 15 Minutes..."
                    };
                    foreach (string s in seventhlist)
                    {
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                    Console.Clear();
                    Home.sA1(SA, name);
                    break;
                default:
                    {
                        Console.WriteLine("Invalid Choice. Press 1 or 2.");
                        break;
                    }
            }

        }
        public static void Drinkk(int drinkk, int SA, string name)
        {
            switch (drinkk)
            {
                case 1:
                    List<string> eighthlist = new List<string>
                    {
                    "I should get a beer maybe, something to help me calm on the way home.",
                    "Now I have my beer, I'll drink this while walking.",
                    "After 15 Minutes..."
                    };
                    foreach (string s in eighthlist)
                    {
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                    Console.Clear();
                    Home.sA1(SA, name);
                    break;
                case 2:
                    List<string> ninthlist = new List<string>
                    {
                    "Just juice maybe, just something to refresh me on the way home",
                    "Now I have my juice, I'll drink this while walking.",
                    "After 15 Minutes..."
                    };
                    foreach (string s in ninthlist)
                    {
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                    Console.Clear();
                    Home.sA1(SA, name);
                    break;
                default:
                    {
                        Console.WriteLine("Invalid Choice. Press 1 or 2.");
                        break;
                    }
            }
        }
    }
}
       

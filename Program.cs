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
            fA(FA, name);
        }
        public static void fA(int FA, string name)
        {
            switch (FA)
            {
                case 1:
                    StartStory(name);
                    break;
                case 2:
                    Console.WriteLine("Closing..");
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Press 1 to Start or 2 to Exit.");
                    break;
            }
        }
        public static void StartStory(string name)
        {
            Console.WriteLine("Loading...");
            Console.WriteLine("CHAPTER 1: Choked by Shadows"); ;

            Console.WriteLine("We're done... I'm tired of you. I can't understand you anymore " + name + ". You and your so called DEPRESSION drains me too!");
            Console.WriteLine("My ear rang and my world suddenly spinned when I heard Avery told me that.");
            Console.WriteLine("Please give me a chance to fix myself... I'm not myself anymore, Avery. I can't lose another part of me.");
            Console.WriteLine("I begged with no shame in the hallway but Avery doesn't care anymore and walked away. I didn't know what to do...");
            Console.WriteLine("My important research defense that I worked hard for will start in 30 minutes... but Avery is the only one keeping me sane.");
            Console.WriteLine("Should I run to Avery and beg (1) or just let it go? (2)");
            Console.Write("Press 1 or 2: ");

            int SA = Convert.ToInt16(Console.ReadLine());
            sA(SA);
        }
        public static void sA(int SA)
        {
            switch (SA)
            {
                case 1:
                    Console.WriteLine("I ran but Avery seems nowhere. I searched every corner for hours to try and fix us, leaving my research defense unattended");
                    Console.WriteLine("But it was all in vain. I didn't see Avery even a little. I was full of regrets... My self is being punished even more.");
                    Console.WriteLine("Losing Avery and securing another failure... my life seems useless even more... Mom, you're wrong. I can't live without you.");
                    Console.WriteLine("As I walk aimlessly, I decided to go... home (1) or at the convenience store (2).");
                    Console.Write("Press 1 or 2: ");
                    int TA= Convert.ToInt16(Console.ReadLine());
                    tA(TA, SA);
                    break;
                case 2:
                    Console.WriteLine("I accepted the reality. I was not enough and was trapped in my own world of problems. I'm better off alone I guess");
                    Console.WriteLine("I forgot Avery and got eaten up by my anxiety and depression. How can I put aside someone so important to me?");
                    Console.WriteLine("As I get ready for my defense. My mind would just float away and my emotions drowned me. I was so out of it and messed up in my defense.");
                    Console.WriteLine("Losing Avery and securing another failure... my life seems useless even more... Mom, you're wrong.I can't live without you.");
                    Console.WriteLine("After unfortuate events. I decided to go... home (1) or at the convenience store (2).");
                    Console.Write("Press 1 or 2: ");
                    int ThA=Convert.ToInt16(Console.ReadLine());
                    tHA(ThA, SA);
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Press 1 to Start or 2 to Exit.");
                    break;
            }
        }
        public static void tA(int TA, int SA)
        {
            switch(TA)
            {
                case 1:
                    sA1(SA);
                    break;
                case 2:
                    Console.WriteLine("I was tired searching around so I just thought of buying a drink before going home.");
                    Console.WriteLine("Hmmm... what should I drink? Beer (1) or Juice (2)");
                    Console.Write("Press 1 or 2: ");
                    int drink =Convert.ToInt16(Console.ReadLine());
                    if (drink == 1)
                    {
                        Console.WriteLine("I should get a beer maybe, something to help me calm on the way home.");
                        Console.WriteLine("Now I have my beer, I'll drink this while walking.");
                        Console.WriteLine("After 15 Minutes...");
                        sA1(SA);
                    }
                    else if (drink == 2)
                    {
                        Console.WriteLine("Just juice maybe, just something to refresh me on the way home");
                        Console.WriteLine("Now I have my beer, I'll drink this while walking.");
                        Console.WriteLine("After 15 Minutes...");
                        sA1(SA);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice. Press 1 to Start or 2 to Exit.");
                    }
                    break;
            }
        }
        public static void tHA(int ThA, int SA)
        {
            switch (ThA)
            { 
                case 1:
                    sA2(SA);
                    break;
                case 2:
                    Console.WriteLine("I was tired searching around so I just thought of buying a drink before going home.");
                    Console.WriteLine("Hmmm... what should I drink? Beer (1) or Juice (2)");
                    Console.Write("Press 1 or 2: ");
                    int drink = Convert.ToInt16(Console.ReadLine());
                    if (drink == 1)
                    {
                        Console.WriteLine("I should get a beer maybe, something to help me calm on the way home.");
                        Console.WriteLine("Now I have my beer, I'll drink this while walking.");
                        Console.WriteLine("After 15 Minutes...");
                        sA2(SA);
                    }
                    else if (drink == 2)
                    {
                        Console.WriteLine("Just juice maybe, just something to refresh me on the way home");
                        Console.WriteLine("Now I have my juice, I'll drink this while walking.");
                        Console.WriteLine("After 15 Minutes...");
                        sA2(SA);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice. Press 1 to Start or 2 to Exit.");
                    }
                    break;
            }
        }
        public static void sA1(int SA)
        {
            Console.WriteLine("I opened my door and my lights are dim as usual but tonight it feels more depressing.");
            Console.WriteLine("I wish mom is still with me, at least I can still taste her home cooked foods for comfort after a tiring day.");
            Console.WriteLine("Thinking about it makes me more emotional. I have no one now... I can't even help myself out of this hell.");
            Console.WriteLine("I'm hungry but I don't have the appetite to eat now. I want to fix this with Avery but I should fix things with my Professor first.");
            Console.WriteLine("Damn, people at school surely judged me again for dissapearing earlier. I failed again. I should stop college... I have no future");
            Console.WriteLine("Never thought living would be this hard. When did I even start being a loser? I lose and fail as always... I'm not good at anything.");
            Console.WriteLine("Hours had passed and all I did was to drown in my thoughts, I hear those voices mocking me again and again. So I thought of doing something else.");
            Console.WriteLine("Should I eat (1) or just grab my phone? (2)");
            int FA= Convert.ToInt16(Console.ReadLine());
            fA(FA);
        }
        public static void sA2(int SA)
        {
            Console.WriteLine("I opened my door and my lights are dim as usual but tonight it feels more depressing.");
            Console.WriteLine("I wish mom is still with me, at least I can still taste her home cooked foods for comfort after a tiring day.");
            Console.WriteLine("Thinking about it makes me more emotional. I have no one now... I can't even help myself out of this hell.");
            Console.WriteLine("I'm hungry but I don't have the appetite to eat now. I want to fix this with Avery but I should forget it I was trash anyways.");
            Console.WriteLine("And yeah, people at school surely judged me again for being stupid earlier, I messed up big time. I should stop college... I have no future");
            Console.WriteLine("Never thought living would be this hard. When did I even start being a loser? I lose and fail as always... I'm not good at anything.");
            Console.WriteLine("Now I'm left with nothing but me... what a shame. When did I lose caring about important things in my life? I even burned my chance in passing college.");
            Console.WriteLine("Hours had passed and all I did was to drown in my thoughts, I hear those voices mocking me again and again. So I thought of doing something else.");
            Console.WriteLine("Should I eat (1) or just grab my phone? (2)");
            int FoA= Convert.ToInt16(Console.ReadLine());
            foA(FoA);
        }
        public static void fA(int FA) 
        {
            switch (FA)
            {
                case 1:
                    Console.WriteLine("Cup noodles will do. I am really hungry right now.");
                    Console.WriteLine("After eating for 10 minutes, I thought of entertaining myself next.");
                    Console.WriteLine("I Grabbed my phone with cracked screen. Ha, even my phone was destroyed because of me? Is this talent or I'm just a walking disaster?");
                    Console.WriteLine("As I scroll through tiktok I saw something about Lucid Dreaming. I was in awe learning that I can control a dream and experience whatever I want.");
                    break;
                case 2:
                    Console.WriteLine("I Grabbed my phone with cracked screen. Ha, even my phone was destroyed because of me? Is this talent or I'm just a walking disaster?");
                    Console.WriteLine("As I scroll through tiktok I saw something about Lucid Dreaming. I was in awe learning that I can control a dream and experience whatever I want.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Press 1 to Start or 2 to Exit.");
                    break;
            }
        }
        public static void foA(int FoA)
        {
            switch (FoA)
            {
                case 1:
                    Console.WriteLine("Cup noodles will do. I am really hungry right now.");
                    Console.WriteLine("After eating for 10 minutes, I thought of entertaining myself next.");
                    Console.WriteLine("I Grabbed my phone with cracked screen. Ha, even my phone was destroyed because of me? Is this talent or I'm just a walking disaster?");
                    Console.WriteLine("As I scroll through tiktok I saw something about Lucid Dreaming. I was in awe learning that I can control a dream and experience whatever I want.");
                    break;
                case 2:
                    Console.WriteLine("I Grabbed my phone with cracked screen. Ha, even my phone was destroyed because of me? Is this talent or I'm just a walking disaster?");
                    Console.WriteLine("As I scroll through tiktok I saw something about Lucid Dreaming. I was in awe learning that I can control a dream and experience whatever I want.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Press 1 to Start or 2 to Exit.");
                    break;
            }
        }
    }
}
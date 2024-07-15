using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Story_Program_BOOC
{
    internal class Home
    {
        public static void sA1(int SA, string name)
        {
            Console.WriteLine("Loading...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("CHAPTER 2:Whispers of the Void");
            List<string> tenthlist = new List<string>
            {
            "I opened my door and my lights are dim as usual but tonight it feels more depressing.",
            "I wish mom is still with me, at least I can still taste her home cooked foods for comfort after a tiring day.",
            "Thinking about it makes me more emotional. I have no one now... I can't even help myself out of this hell."
            };
            foreach (string s in tenthlist)
            {
                Console.WriteLine(s);
                Console.ReadKey();
            }
            if (SA == 1)
            {
                List<string> eleventhlist = new List<string>
                {
                "I'm hungry but I don't have the appetite to eat now. I want to fix this with Avery but I should fix things with my Professor first.",
                "Damn, people at school surely judged me again for dissapearing earlier. I failed again. I should stop college... I have no future"
                };
                foreach (string s in eleventhlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }

            }
            else if (SA == 2)
            {
                List<string> twelfthlist = new List<string>
                {
                "I'm hungry but I don't have the appetite to eat now. I want to fix this with Avery but I should forget it I was trash anyways.",
                "And yeah, people at school surely judged me again for being stupid earlier, I messed up big time. I should stop college... I have no future"
                };
                foreach (string s in twelfthlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
            }
            List<string> thirteenthlist = new List<string>
            {
            "Never thought living would be this hard. When did I even start being a loser? I lose and fail as always... I'm not good at anything.",
            "Hours had passed and all I did was to drown in my thoughts, I hear those voices mocking me again and again. So I thought of doing something else.",
            };
            foreach (string s in thirteenthlist)
            {
                Console.WriteLine(s);
                Console.ReadKey();
            }
            Console.Write("Should I eat (1) or just grab my phone? (2): ");
            int FoA = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            fA(FoA,name);
        }
        public static void fA(int FoA, string name)
        {
            if (FoA == 1)
            {
                List<string> fourteenthlist = new List<string>
                {
                "Cup noodles will do. I am really hungry right now.",
                "After eating for 10 minutes, I thought of entertaining myself next.",
                "I Grabbed my phone with cracked screen. Ha, even my phone was destroyed because of me? Is this talent or I'm just a walking disaster?",
                "As I scroll through tiktok I saw something about Lucid Dreaming.I was in awe learning what it can do and how it works."
                };
                foreach (string s in fourteenthlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
                lD(name);
            }
            else if (FoA == 2)
            {
                List<string> sixteenthlist = new List<string>
                {
                "I Grabbed my phone with cracked screen. Ha, even my phone was destroyed because of me? Is this talent or I'm just a walking disaster?",
                "As I scroll through tiktok I saw something about Lucid Dreaming.I was in awe learning what it can do and how it works."
                };
                foreach (string s in sixteenthlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
                lD(name);

            }
            else
            {
                Console.WriteLine("Invalid Choice. Press 1 or 2."); 
            }
        }
        public static void lD(string name)
        {
            List<string> seventeenthlist = new List<string>
                {
            "'Experiencing lucid dreams allows you to take charge of your dreams and fly through the air, interact with fantastical animals, and explore an infinite number of possibilities.",
            "It's a method to play with your dreams, where you can be awake and do anything you can dream of. It provides a fascinating look into the workings of the mind while you sleep.",
            "Keep a dream journal to identify dream patterns before attempting to enter a lucid dream. Ensure that you are awake, check your reality regularly during the day by pushing your finger into your hand.",
            "To improve your chances of having lucid dreams, close your eyes and picture yourself waking up in a dream.",
            "While most people report lucid dreaming to be safe, on rare occasions it might cause symptoms like sleep paralysis or confusion between dream and reality when awake'.",
            "As I've heard the video mention sleep paralysis I felt scared but I have nothing to lose right? I mean, lucid dreaming might help me."
            };
            foreach (string s in seventeenthlist)
            {
                Console.WriteLine(s);
                Console.ReadKey();
            }
            Console.Write("I didn't know that I am capable of creating what I want in my mind. But should I ignore the part about sleep paralysis? Yes(1) or No(2)?:");
            int PLD = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            pLD(PLD, name);

        }
        public static void pLD(int PLD, string name)
        {
            if (PLD == 1)
            {
                List<string> eighteenthlist = new List<string>
                {
                "Hmm... It's a rare to have sleep paralysis so yeah nevermind, I'm not that special to experience something rare.",
                "I searched for more information about lucid dreaming and the things that I must do to ensure that I'll experience it later.",
                "Time passed for about 2 hours  and it is really late now, I guess it's time to put what I have learned the whole time to test!",
                "This is my first time in a while to get excited huh? Maybe life isn't that bad?"
                };
                foreach (string s in eighteenthlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
                Console.Clear();
                Lucid_Dream.StartDream(name);
            }
            else if (PLD == 2)
            {
                List<string> nineteenthlist = new List<string>
                {
                "Yeah, sleep paralysis seems scary so I continued watching the video",
                "'Sleep paralysis is where you're temporarily unable to move upon waking from a lucid dream, and difficulty distinguishing between dreams and reality, which can affect your mental well-being. ",
                "Practicing moderation and mindfulness while exploring lucid dreaming can help mitigate these risks and ensure a balanced approach to this fascinating experience.'",
                "Finishing the video, I realized that sleep paralysis can be a good thing? Come on, not knowing what's real and not might make me happy for long, I would want to stay sleeping forever.",
                "I searched for more information about lucid dreaming and the things that I must do to ensure that I'll experience it later.",
                "Time passed for about 2 hours  and it is really late now, I guess it's time to put what I have learned the whole time to test!",
                "This is my first time in a while to get excited huh? Maybe life isn't that bad?"
                };
                foreach (string s in nineteenthlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
                Console.Clear();
                Lucid_Dream.StartDream(name);
            }
            else
            {
                Console.WriteLine("Invalid Choice. Press 1 or 2.");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Story_Program_BOOC
{
    internal class Lucid_Dream
    {
        public static void StartDream(string name)
        {
            Console.WriteLine("Loading...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("CHAPTER 3: Slumbering Into Nightmare");
            List<string> twentiethlist = new List<string>
                {
            "I got into my bed feeling excited and nervous at the same time but now that I can create my own reality I really wanted to do this.",
            "Escape into the reality is now a choice and I'm glad I knew about this right when I thought I have no hope in life.",
            "This won't change anything in my life but doing this can help me mentally. Didn't know being positive is in me.... I'm not really miserable huh?",
            "After doing what I am supposed to do I drifted away into deep slumber. I am starting to feel light, I feel so relieved strangely and that's when it hit me.",
            "I succeded in having my first ever lucid dream. I then saw myself standing in the hallway and Avery was smiling at me.'Goodluck "+ name+ "! Break a leg in your defense! I'll wait for you here'.",
            "It felt surreal to see Avery smile at me like that, I got really happy and felt complete again. My phone rang and I was curious on who could be calling me... when I answered.",
            "I heard mom's voice... I was in shock as I also hear her support me in my upcoming defense. 'Do your best " + name + ", I'll cook you your favorite food once you get home okay! I love you my sweet child'.",
            "She ended the call and I was just crying in joy of tears. Who knew that I would hear my mom again? People at the campus were also rooting for me. This is new to me. "
            };
            foreach (string s in twentiethlist)
            {
                Console.WriteLine(s);
                Console.ReadKey();
            }
            Console.Write("Now that everything seems great should I just skip the defense? I mean it's still my own choice right? Skip it (1) or Continue (2): ");
            int RA= Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            NM(RA);
        }
        public static void NM(int RA)
        {
            if(RA==1)
            {
                List<string> twentyfirstlist = new List<string>
                {
                "When I was about to open the door for my research defense, I changed my mind and turned back but my papers fell so I picked it up first.",
                "As I got up, I noticed the lights turned off and the temperature dropped and it became chilly. I panicked as this is not what I am imagining to do.",
                "I thought I have full control here but I guess I was wrong. I thought of a happy song like... uhm a child's song and it did play in the hallway. But afterwards it became distorted and made things more eerie.",
                "I look further in the dark hallway and I saw Avery from afar. Just standing and smiling...psychoticly, it seems like Avery is mocking me for being scared.",
                "Avery's smile went from lovely to traumatizing as I've seen the skin on Avery's face rip as the smile goes up continously on the ears.",
                "I wanted to wake up but it feels like I can't, I can only control my eyes and my body won't move. I can't shout even. Is this sleep paralysis?",
                };
                foreach (string s in twentyfirstlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
                Console.Write("What should I do? Try to focus on moving a single finger, hoping it will break the paralysis(1) or Close my eyes and concentrate on calming my mind, hoping to regain control(2) or do nothing(press any number?): ");
                int SPP= Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                sPP(SPP);
            }
            else if(RA==2)
            {
                List<string> twentysecondlist = new List<string>
                {
                "I opened the door towards the place where I will defend my work and I suddenly dropped my papers and I was embarassed.",
                "As I got up, I noticed the lights turned off and the temperature dropped and it became chilly. I panicked as this is not what I am imagining to do.",
                "I ran to go back in the hallway to go back to Avery, why did I even tried to continue this? I thought I have full control here but I guess I was wrong.",
                "I thought of a happy song like... uhm a child's song and it did play in the hallway. But afterwards it became distorted and made things more eerie.",
                "I look further in the dark hallway and I saw Avery from afar. Just standing and smiling...psychoticly, it seems like Avery is mocking me for being scared.",
                "Avery's smile went from lovely to traumatizing as I've seen the skin on Avery's face rip as the smile goes up continously on the ears.",
                "I wanted to wake up but it feels like I can't, I can only control my eyes and my body won't move. I can't shout even. Is this sleep paralysis?"
                };
                foreach (string s in twentysecondlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
                Console.Write("What should I do? Try to focus on moving a single finger, hoping it will break the paralysis(1) or Close my eyes and concentrate on calming my mind, hoping to regain control(2) or nothing (press any number)?: ");
                int SPP= Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                sPP(SPP);
            }
            else
            {
              Console.WriteLine("Invalid Choice. Press 1 or 2.");
            }
        }
        public static void sPP(int SPP)
        {
            if (SPP == 1)
            {
                List<string> twentythirdlist = new List<string>
                {
                "I tried with all of my might, focusing on my index finger. Slowly, agonizingly, I managed to twitch it.",
                "The paralysis begins to loosen, and I felt that my control to my body is returning.",
                "I got scared but I still want to continue in this world and I think I can handle it now. Everything is back to normal anyways.",
                };
                foreach (string s in twentythirdlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
                Console.WriteLine("Where should I appear next? Avery's Place(1) or Home with Mother(2)?: ");
                int place = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                cD(place);
            }

            else if (SPP == 2)
            {
                List<string> twentyfourthlist = new List<string>
                {
                "I closed my eyes and took a deep, steady breaths, forcing myself to remain calm.",
                "Gradually, the eerie sensations fade, and I felt that my control to my body is returning.",
                "I got scared but I still want to continue in this world and I think I can handle it now. Everything is back to normal anyways."
                };
               foreach (string s in twentyfourthlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
                Console.WriteLine("Where should I appear next? Avery's Place(1) or Home with Mother(2)?: ");
                int place = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                cD(place);
                
            }
            else
            {
                List<string> twentyfifthlist = new List<string>
                {
                "Unable to make a clear decision, I remain trapped in the paralyzing grip of fear, the shadow of Avery turning into a different entity inching closer.",
                "I tried to run but it was too late. This dark, tall, and eerie figure strangled my neck and I was losing my breath slowy.",
                "Flash Report! \t A person was found dead in their bed at an apartment, prompting an ongoing investigation into the circumstances surrounding their death."
                };
                foreach (string s in twentyfifthlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
            }                   
        }
        public static void cD(int place)
        {
            if (place == 1)
            {
                List<string> twentysixthlist = new List<string>
                {
                "I imagined myself at Avery's place, hoping to find some comfort in the familiar surroundings.",
                "As I appeared there, everything seemed normal. Avery was still smiling, but this time warmly, as if reassuring me.",
                "I thanked Avery for being there and expressing support, feeling a sense of relief in this dream world.",
                "I then decided to explore more of this lucid dream, trying out different experiences and testing the limits of my newfound abilities.",
                "It was an adventure unlike any other, where I could shape reality and experience things beyond imagination.",
                "Eventually, I felt ready to wake up, feeling satisfied with this extraordinary journey.",
                "With a smile on my face, I woke up in the real world, feeling refreshed and inspired.",
                "However, as I tried to move, I realized something was wrong. It felt like I was still dreaming.",
                "Panic set in as I struggled to wake up for real, but each attempt only brought me back to another layer of the dream.",
                "Terrified, I found myself trapped in a loop, unable to distinguish between dream and reality.",
                "The comforting smile of Avery now seemed traumatizing, and the once warm surroundings turned back into eerie and unsettling.",
                "In a desperate attempt to break free, I screamed, hoping someone would hear me in the real world.",
                "But the only response was the echo of my own voice, fading into the abyss of the dream world.",
                "And so, I remained trapped in the endless cycle of the dream, forever lost between waking and sleeping.",
                "THE END"
                };
                foreach (string s in twentysixthlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
            }
            else if (place == 2)
            {
                List<string> twentyseventhlist = new List<string>
                {
                "I imagined myself at home with my mother, longing for the warmth and love that her presence brought.",
                "As I appeared there, I was greeted by my mother's embrace, her words of encouragement filling my heart with joy.",
                "I cherished this moment, realizing how much my mother loves me.",
                "Together, we enjoyed a peaceful time, sharing laughter and stories, just like we used to.",
                "It was a moment of pure happiness, a reminder of the love that gives strength in both dreams and reality.",
                "Before waking up, I hugged my mother tightly, grateful for this surreal yet precious experience.",
                "As I opened my eyes in the real world, I carried with me a renewed sense of purpose and love.",
                "The dream taught me that even in the realm of dreams, the connections we cherish can bring us solace and strength.",
                "And as I faced the real life, I did so with the unwavering support of my loved ones in mind.",
                "Her words echoed in my heart, helping me forward with confidence and determination.",
                "With a heart filled with gratitude and love, I stepped into the future, knowing that I was never truly alone.",
                "Dreams, both lucid and waking, had shown me the power of imagination and the strength of human connection.",
                "THE END"
                };
                foreach (string s in twentyseventhlist)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice. Press 1 or 2.");
            }
        }
    }
}
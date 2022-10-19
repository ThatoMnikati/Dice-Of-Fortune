using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DiceOfFortune
{
    class Dice
    {
        public static void RollDie()
        {
            string[] roll = new string[6];
            roll[0] = "If you have an idea, Make it into reality";
            roll[1] = "To achieve wisdom, you must first desire it";
            roll[2] = "Free your mind and the rest will follow";
            roll[3] = "Everything will work out";
            roll[4] = "Focus on your health and well-being for now. It won't wait.";
            roll[5] = "Seek out a new environment if you're stuck in a rut";

            Random rand = new Random();
            int fort = rand.Next(0, roll.Length);

            WriteLine(roll[fort]);
        }
        
        static void Main(string[] args)
        {
            WriteLine("Press any key to roll the die");
            ReadKey();
            WriteLine("Your fortune is...");
            RollDie();
            ReadKey();
        }
    }
}

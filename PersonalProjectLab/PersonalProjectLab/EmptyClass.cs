using System;
namespace PersonalProjectLab
{
    public class EmptyClass
    {
        public static void GetPitch()
        {
            Console.WriteLine("Please input the number that you are currently at in the batting order from 1 to 9");
            string BatterNumber = Console.ReadLine();
            int BattingOrder = Convert.ToInt32(BatterNumber);
            if (BattingOrder == 1)
            {
                Console.WriteLine("Throw a Fastball.");
            }
            if (BattingOrder == 2)
            {
                Console.WriteLine("Throw a Curveball");
            }
            if (BattingOrder == 3)
            {
                Console.WriteLine("Throw a Slider");
            }
            if (BattingOrder == 4)
            {
                Console.WriteLine("Throw a Sinker");
            }
            if (BattingOrder == 5)
            {
                Console.WriteLine(" Throw a Screwball");
            }
            if (BattingOrder == 6)
            {
                Console.WriteLine(" Throw a Changeup");
            }
            if (BattingOrder == 7)
            {
                Console.WriteLine("Throw a Forkball");
            }
            if (BattingOrder == 8)
            {
                Console.WriteLine("Throw a Splitter");
            }
            if (BattingOrder == 9)
            {
                Console.WriteLine("Throw a Knuckleball");
            }
        }
    }
}
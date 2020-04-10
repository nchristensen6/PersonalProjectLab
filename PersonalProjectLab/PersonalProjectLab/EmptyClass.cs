using System;
namespace PersonalProjectLab
{
    public class EmptyClass
    {
        public static string GetPitch()
        {
            Console.WriteLine("Please input the number that you are currently at in the batting order from 1 to 9");
            string BatterNumber = Console.ReadLine();
            int BattingOrder = Convert.ToInt32(BatterNumber);
            string choice = null;
            if (BattingOrder == 1)
            {
                choice="Throw a Fastball.";
            }
            if (BattingOrder == 2)
            {
                choice="Throw a Curveball";
            }
            if (BattingOrder == 3)
            {
                choice="Throw a Slider";
            }
            if (BattingOrder == 4)
            {
                 choice= "Throw a Sinker";
            }
            if (BattingOrder == 5)
            {
                choice= " Throw a Screwball";
            }
            if (BattingOrder == 6)
            {
                choice=" Throw a Changeup";
            }
            if (BattingOrder == 7)
            {
                choice="Throw a Forkball";
            }
            if (BattingOrder == 8)
            {
                choice="Throw a Splitter";
            }
            if (BattingOrder == 9)
            {
                choice="Throw a Knuckleball";
            }
            return choice;
        }
    }
        
}
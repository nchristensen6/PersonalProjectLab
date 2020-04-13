using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number that you are currently at in the batting order from 1 to 9");
            string BatterNumber = Console.ReadLine();
            int BattingOrder = Convert.ToInt32(BatterNumber);
            Console.WriteLine(EmptyClass.GetPitch(BattingOrder));
        }
    }
}
using System;
using System.Threading;

namespace VirtualDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] diceroll = { 1, 2, 3, 4, 5, 6 };
            int[] diceroll2 = { 1, 2, 3, 4, 5, 6 };
            Random random = new Random();
            Random random2 = new Random();
            int index2 = random2.Next(diceroll2.Length);
            int index = random.Next(diceroll.Length);
            int FinalResult = diceroll[index] + diceroll2[index2];

            Console.WriteLine("you rolled 2 dice and got... :");
            Thread.Sleep(2000);
            Console.WriteLine(diceroll[index]);
            Thread.Sleep(500);
            Console.WriteLine("on one of them..");
            Thread.Sleep(300);
            Console.WriteLine("and");
            Thread.Sleep(1000);
            Console.WriteLine(diceroll2[index2]);
            Thread.Sleep(200);
            Console.WriteLine("on the other one");
            Thread.Sleep(1500);
            Console.WriteLine($"so that makes: " + ( FinalResult));
            Thread.Sleep(600);
            
            

        }
    }
}

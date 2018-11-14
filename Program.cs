using CTRE;
using System;
using System.Threading;
using Microsoft;
using BalanceBot.Platform;

namespace BalanceBot
{
    public class Program
    {
        

        public static void Main()
        {

            while (true)
            {
                CTRE.Phoenix.Pixy2CCC.Block b = Hardware.pixy.ccc.GetBlock();
                if (b != null)
                {
                    // do something
                }
            }
        }
    }
}
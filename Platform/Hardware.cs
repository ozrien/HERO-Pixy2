using CTRE;

namespace BalanceBot.Platform
{
    public static class Hardware
    {
        //Create Pixy
        public static CTRE.Phoenix.Pixy2UART pixy = new CTRE.Phoenix.Pixy2UART(CTRE.HERO.IO.Port6, 115200);

    }
}
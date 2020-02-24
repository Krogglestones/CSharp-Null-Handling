using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayerCharacter stan = new PlayerCharacter(new DiamondSkinDefense())
            {
                Name = "Stan"
            };
            PlayerCharacter randy = new PlayerCharacter(new IronBonesDefense())
            {
                Name = "Randy"
            };
            PlayerCharacter craig = new PlayerCharacter(SpecialDefense.Null)
            {
                Name = "Craig"
            };

            stan.Hit(10);
            randy.Hit(10);
            craig.Hit(10);

            Console.ReadLine();
        }
    }
}

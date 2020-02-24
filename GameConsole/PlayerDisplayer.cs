using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {

            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Players name is null or white space");
            }
            else
            {
            Console.WriteLine(player.Name);

            }

            //conditional operator
            // int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;
            
            //null-coalescing operator
            int days = player.DaysSinceLastLogin ?? -1;

           
            //  OR 

            // int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);

            Console.WriteLine($"{days} since last login");


            //if (!player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine("No Value");
            //}
            //else
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin);
            //}

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No DOB specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if(player.IsNoob == null)
            {
                Console.WriteLine("Noob status unknown");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("Player is a noob");
            }
            else
            {
                Console.WriteLine("Player has experience");
            }
        }
    }
}

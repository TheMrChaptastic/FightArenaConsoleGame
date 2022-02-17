using System;

namespace TextAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game.Welcome();
            var gameover = false;
            var username = Game.GetUserName();
            Console.WriteLine();
            var player = ClassFactory.ChooseClass();
            Console.WriteLine();
            var fightsWon = 0;
            Console.WriteLine($"Hello {player.Class} {username}. You will now face 3 opponents.\nYou will be the victor or perish.\nHit Enter to continue.");
            var uinput = Console.ReadLine();
            while (!gameover)
            {
                if (fightsWon >= 3)
                {
                    Console.WriteLine("You have succeeded! Congratulations!");
                    gameover = true;
                    break;
                }
                Console.WriteLine($"{username}\nHP: {player.HP} / {player.MaxHP}\nGold: {player.Gold}");

                Console.WriteLine("Choose Option: Fight / Heal (2hp per gold)");
                uinput = Console.ReadLine();
                Console.Clear();
                switch (uinput.ToLower())
                {
                    case "heal":
                        Heal.HealPlayer(player);
                        break;
                    case "fight":
                        Fight.StartFight(player);
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }
                if (player.HP <= 0)
                {
                    Console.WriteLine("You have died in combat. Game Over.");
                    gameover = true;
                    break;
                }
                else if (uinput.ToLower() == "fight")
                {
                    fightsWon++;
                    var winStr = fightsWon == 3 ? "You have finished your last fight. Your legend will live on forever." : "You have won your fight.";
                    Console.WriteLine(winStr);
                    Console.WriteLine();
                }
            }
        }
    }
}

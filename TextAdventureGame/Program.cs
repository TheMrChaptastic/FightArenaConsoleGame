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
            var uInput = Game.UserInputThenClear();
            while (!gameover)
            {
                Console.WriteLine($"{username}\nHP: {player.HP} / {player.MaxHP}\nGold: {player.Gold}");
                Console.WriteLine("Choose Option: Fight / Heal (2hp per gold)");
                uInput = Game.UserInputThenClear();
                switch (uInput.ToLower())
                {
                    case "heal":
                        Heal.HealPlayer(player);
                        break;
                    case "fight":
                        Fight.StartFight(player, fightsWon);
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }

                if (player.HP <= 0)
                {
                    Console.WriteLine("RIP (Hit Enter)");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Game.UserInputThenClear();
                    Console.WriteLine("You have died in combat. Game Over.");
                    gameover = true;
                }
                else if (uInput.ToLower() == "fight")
                {
                    fightsWon++;
                    var winStr = fightsWon == 3 ? "You have finished your last fight. Your legend will live on forever." : "You have won your fight.";
                    Console.WriteLine(winStr);
                    Console.WriteLine();
                }

                if (fightsWon == 3)
                {
                    Console.WriteLine("You have succeeded! Congratulations!\n");
                    Console.WriteLine($"{player.Class} {username} Score: {player.HP + player.Gold * 3}\n");
                    gameover = true;
                }
                if (gameover)
                {
                    Console.WriteLine("Play Again? y/n");
                    uInput = Console.ReadLine();
                    gameover = uInput.ToLower() == "y" ? false : true;
                    if (!gameover)
                    {
                        Console.ResetColor();
                        Console.Clear();
                        player = ClassFactory.ChooseClass();
                        Console.WriteLine();
                        fightsWon = 0;
                    }
                }
            }
        }
    }
}

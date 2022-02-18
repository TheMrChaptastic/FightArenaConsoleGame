using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TextAdventureGame
{
    public static class Game
    {
        public static void Welcome()
        {
            string[] title = new string[] { @"                                        ", @"           _____  ______ _   _          ", @"     /\   |  __ \|  ____| \ | |   /\    ", 
                @"    /  \  | |__) | |__  |  \| |  /  \   ", @"   / /\ \ |  _  /|  __| | . ` | / /\ \  ", @"  / ____ \| | \ \| |____| |\  |/ ____ \ ", @" /_/    \_\_|  \_\______|_| \_/_/    \_\", 
                @"                                        ", @"                                        ",};
            foreach(var s in title)
            {
                Console.WriteLine(s);
                Thread.Sleep(250);
            }
            var enter = "                 Hit Enter              ".ToCharArray();
            foreach(var c in enter)
            {
                Console.Write(c);
                Thread.Sleep(40);
            }

            Console.ReadLine();
            Console.Clear();
        }

        public static string GetUserName()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }

        public static string UserInputThenClear()
        {
            var uinput = Console.ReadLine();
            Console.Clear();
            return uinput;
        }
    }
}

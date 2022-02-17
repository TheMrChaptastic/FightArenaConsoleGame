using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public static class ClassFactory
    {
        public static IProfession ChooseClass()
        {
            Console.WriteLine("Warrior, Ranger, Mage");
            Console.WriteLine("Choose a Class:");
            var uInput = Console.ReadLine();
            switch (uInput.ToLower())
            {
                case "warrior":
                    return new Warrior();
                case "ranger":
                    return new Ranger();
                case "mage":
                    return new Mage();
                default:
                    Console.WriteLine("Invalid Input.");
                    return ChooseClass();
            }
        }
    }
}

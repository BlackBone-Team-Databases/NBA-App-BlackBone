using System;

namespace NBABlackBone.Core.Menu
{
    public static class PrintMenu
    {

        public static void MainMenu()
        {
            Console.WriteLine("Choose from the options below");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Generete Report");
            Console.WriteLine("6. Fill Database");
            Console.WriteLine("0. Exit");
        }

        public static void CreateMenu()
        {
            Console.WriteLine("Choose what to create:");
            Console.WriteLine("1. Create Player");
            Console.WriteLine("2. Create Team");
            Console.WriteLine("3. Back");
        }

        public static void ReadMenu()
        {
            Console.WriteLine("Choose what to read:");
            Console.WriteLine("1. Read All Players");
            Console.WriteLine("2. Read Player by ID");
            Console.WriteLine("3. Read All Teams");
            Console.WriteLine("4. Read Team by ID");
            Console.WriteLine("5. Read Player Stats by ID");
            Console.WriteLine("6. Back");
        }

        public static void UpdateMenu()
        {
            Console.WriteLine("Choose what to update:");
            Console.WriteLine("1. Update Player Info");
            Console.WriteLine("2. Update Team Info");
            Console.WriteLine("3. Update Player Stats");
            Console.WriteLine("4. Back");
        }

        public static void DeleteMenu()
        {
            Console.WriteLine("Choose what to delete:");
            Console.WriteLine("1. Delete Player (will delete the player statistic also)");
            Console.WriteLine("2. Delete Team");
            Console.WriteLine("3. Back");
        }
    }
}

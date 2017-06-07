using NbaBlackBone.Core.Contracts;

namespace NBABlackBone.Core.Menu
{
    public class Menu
    {
        private IReader reader;
        private IWriter writer;

        public Menu(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Start()
        {
            int input = 6;
            while (input != 0)
            {
                PrintMainMenu();

                input = Input();

                PrintDelimeter();

                switch (input)
                {
                    case 1:
                        PrintCreateMenu();
                        input = Input();
                        break;
                    case 2:
                        PrintReadMenu();
                        input = Input();
                        break;
                    case 3:
                        PrintUpdateMenu();
                        input = Input();
                        break;
                    case 4:
                        PrintDeleteMenu();
                        input = Input();
                        break;
                    case 5:
                        // TODO : GenerateReportCommand()
                        break;
                    case 0:
                        return;
                    default:

                        this.writer.WriteLine("Incorect Input value");
                        break;
                }
                this.writer.EmptyLine();
                this.writer.WriteLine("===================================================");
                this.writer.EmptyLine();

            }
        }

        private void PrintMainMenu()
        {
            this.writer.WriteLine("Choose from the options below");
            this.writer.WriteLine("1. Create");
            this.writer.WriteLine("2. Read");
            this.writer.WriteLine("3. Update");
            this.writer.WriteLine("4. Delete");
            this.writer.WriteLine("5. Generete Report");
            this.writer.WriteLine("0. Exit");
            this.writer.EmptyLine();
        }

        private void PrintCreateMenu()
        {
            this.writer.WriteLine("Choose what to create:");
            this.writer.WriteLine("1. Create Player");
            this.writer.WriteLine("2. Create Team");
            this.writer.WriteLine("3. Back");
        }

        private void PrintReadMenu()
        {
            this.writer.WriteLine("Choose what to read:");
            this.writer.WriteLine("1. Read Player");
            this.writer.WriteLine("2. Read Team");
            this.writer.WriteLine("3. Read Player Stats");
            this.writer.WriteLine("4. Back");
        }

        private void PrintUpdateMenu()
        {
            this.writer.WriteLine("Choose what to update:");
            this.writer.WriteLine("1. Update Player Info");
            this.writer.WriteLine("2. Update Team Info");
            this.writer.WriteLine("3. Update Player Stats");
            this.writer.WriteLine("4. Back");
        }

        private void PrintDeleteMenu()
        {
            this.writer.WriteLine("Choose what to delete:");
            this.writer.WriteLine("1. Delete Player (will delete the player statistic also)");
            this.writer.WriteLine("2. Delete Team");
            this.writer.WriteLine("3. Back");
        }

        private int Input()
        {
            int input = 6; // TODO: it should be 0 or something else
            bool result = int.TryParse(this.reader.ReadLine(), out input);
            if (!result)
            {
                this.writer.WriteLine("Incorect input value");
            }

            return input;
        }

        private void PrintDelimeter()
        {
            this.writer.WriteLine("===================================================");
        }
    }
}

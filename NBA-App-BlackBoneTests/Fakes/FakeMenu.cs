using NBABlackBone.Core.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NbaBlackBone.Core.Contracts;
using NBABlackBone.Core.Commands;

namespace NBA_App_BlackBoneTests.Fakes
{
    class FakeMenu : Menu
    {
        internal IReader reader;
        internal IWriter writer;
        internal ICommandFactory commandFactory;

        public FakeMenu(IReader reader, IWriter writer, ICommandFactory commandFactory) : base(reader, writer, commandFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandFactory = commandFactory;
        }

        public void Input()
        {
            base.Input();
        }

        public void CreateCommandMenu(int input)
        {
            base.CreateCommandMenu(input);
        }

        public void UpdateCommandMenu(int input)
        {
            base.UpdateCommandMenu(input);
        }

        public void ReadCommandMenu(int input)
        {
            base.ReadCommandMenu(input);
        }

        public void DeleteCommandMenu(int input)
        {
            base.DeleteCommandMenu(input);
        }
    }
}

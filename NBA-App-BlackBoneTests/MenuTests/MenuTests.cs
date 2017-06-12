using Moq;
using NBA_App_BlackBoneTests.Fakes;
using NbaBlackBone.Core.Contracts;
using NBABlackBone.Core.Commands;
using NBABlackBone.Core.Menu;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_App_BlackBoneTests.MenuTests
{
    [TestFixture]
    class MenuTests
    {
        [Test]
        public void Constructor_WhenCalled_CreateInstanceOfObject()
        {
            //Arrange
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            //reader.Setup(x => x.ReadLine()).Returns("2");
            var commandFactory = new Mock<ICommandFactory>();

            //Act
            var menu = new Menu(reader.Object, writer.Object, commandFactory.Object);

            //Assert
            Assert.IsInstanceOf<Menu>(menu);
        }

        [Test]
        public void Constructor_WhenCalled_SetsValueToReader()
        {
            //Arrange
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            //reader.Setup(x => x.ReadLine()).Returns("2");
            var commandFactory = new Mock<ICommandFactory>();
            
            //Act
            var menu = new FakeMenu(reader.Object, writer.Object, commandFactory.Object);

            //Assert
            Assert.AreEqual(menu.reader, reader.Object);
        }

        [Test]
        public void Constructor_WhenCalled_SetsValueToWriter()
        {
            //Arrange
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            //reader.Setup(x => x.ReadLine()).Returns("2");
            var commandFactory = new Mock<ICommandFactory>();

            //Act
            var menu = new FakeMenu(reader.Object, writer.Object, commandFactory.Object);

            //Assert
            Assert.AreEqual(menu.writer, writer.Object);
        }

        [Test]
        public void Constructor_WhenCalled_SetsValueToCommandFactory()
        {
            //Arrange
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            //reader.Setup(x => x.ReadLine()).Returns("2");
            var commandFactory = new Mock<ICommandFactory>();

            //Act
            var menu = new FakeMenu(reader.Object, writer.Object, commandFactory.Object);

            //Assert
            Assert.AreEqual(menu.commandFactory, commandFactory.Object);
        }

        [Test]
        public void Input_WhenCalled_CallsReaderOnce()
        {
            //Arrange
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            reader.Setup(x => x.ReadLine()).Returns("2");
            var commandFactory = new Mock<ICommandFactory>();
            var menu = new FakeMenu(reader.Object, writer.Object, commandFactory.Object);

            //Act
            menu.Input();

            //Assert
            reader.Verify(x => x.ReadLine(), Times.Once());
        }

        [Test]
        public void Input_ReadInvalidValue_CallsWriteOnce()
        {
            //Arrange
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            reader.Setup(x => x.ReadLine()).Returns("e");
            var commandFactory = new Mock<ICommandFactory>();
            var menu = new FakeMenu(reader.Object, writer.Object, commandFactory.Object);

            //Act
            menu.Input();

            //Assert
            writer.Verify(x => x.WriteLine("Incorect input value"), Times.Once());
        }

        [Test]
        public void CreateCommandMenu_InputValue1_CallsCommandFactory_CreatePlayerCommandOnce()
        {
            //Arrange
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            var commandFactory = new Mock<ICommandFactory>();
            var menu = new FakeMenu(reader.Object, writer.Object, commandFactory.Object);

            //Act
            menu.CreateCommandMenu(1);

            //Assert
            commandFactory.Verify(x => x.CreatePlayerCommand(), Times.Once());
        }

        [Test]
        public void CreateCommandMenu_InputValue2_CallsCommandFactory_CreateTeamCommandOnce()
        {
            //Arrange
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            var commandFactory = new Mock<ICommandFactory>();
            var menu = new FakeMenu(reader.Object, writer.Object, commandFactory.Object);

            //Act
            menu.CreateCommandMenu(2);

            //Assert
            commandFactory.Verify(x => x.CreateTeamCommand(), Times.Once());
        }


        [Test]
        public void UpdateCommandMenu_InputValue1_CallsCommandFactory_UpdatePlayerCommandOnce()
        {
            //Arrange
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            var commandFactory = new Mock<ICommandFactory>();
            var menu = new FakeMenu(reader.Object, writer.Object, commandFactory.Object);

            //Act
            menu.UpdateCommandMenu(1);

            //Assert
            commandFactory.Verify(x => x.UpdatePlayerCommand(), Times.Once());
        }

        [Test]
        public void UpdateCommandMenu_InputValue2_CallsCommandFactory_UpdateTeamCommandOnce()
        {
            //Arrange
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            var commandFactory = new Mock<ICommandFactory>();
            var menu = new FakeMenu(reader.Object, writer.Object, commandFactory.Object);

            //Act
            menu.UpdateCommandMenu(2);

            //Assert
            commandFactory.Verify(x => x.UpdateTeamCommand(), Times.Once());
        }

        [Test]
        public void UpdateCommandMenu_InputValue3_CallsCommandFactory_UpdatePlayerStatisticCommandOnce()
        {
            //Arrange
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            var commandFactory = new Mock<ICommandFactory>();
            var menu = new FakeMenu(reader.Object, writer.Object, commandFactory.Object);

            //Act
            menu.UpdateCommandMenu(3);

            //Assert
            commandFactory.Verify(x => x.UpdatePlayerStatisticCommand(), Times.Once());
        }

        
    }
}

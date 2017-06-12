using Moq;
using NbaBlackBone.Models;
using NbaBlackBone.Models.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_App_BlackBoneTests.ModelsTests
{
    [TestFixture]
    class PlayersTests
    {
        [Test]
        public void Players_PropertyId_SetsValueCorrect()
        {
            //Arrange
            var player = new Player();

            //Act
            player.Id = 5;

            //Assert
            Assert.AreEqual(player.Id, 5);

        }

        [Test]
        public void Players_PropertyFirstName_SetsValueCorrect()
        {
            //Arrange
            var player = new Player();

            //Act
            player.FirstName = "Pesho";

            //Assert
            Assert.AreEqual(player.FirstName, "Pesho");

        }

        [Test]
        public void Players_PropertyLastName_SetsValueCorrect()
        {
            //Arrange
            var player = new Player();

            //Act
            player.LastName = "Peshev";

            //Assert
            Assert.AreEqual(player.LastName, "Peshev");

        }

        [Test]
        public void Players_PropertyPosition_SetsValueCorrect()
        {
            //Arrange
            var player = new Player();

            //Act
            player.Position = 5;

            //Assert
            Assert.AreEqual(player.Position, 5);

        }

        [Test]
        public void Players_PropertyPlayerStatistic_SetsValueCorrect()
        {
            //Arrange
            var PS = new Mock<PlayerStatistic>();
            var player = new Player();

            //Act
            player.PlayerStatistic = PS.Object;

            //Assert
            Assert.AreEqual(player.PlayerStatistic, PS.Object);

        }

        [Test]
        public void Players_PropertyTeams_SetsValueCorrect()
        {
            //Arrange
            var team = new Mock<Team>();
            var player = new Player();

            //Act
            player.Team = team.Object;

            //Assert
            Assert.AreEqual(player.Team, team.Object);

        }

        [Test]
        public void Players_ToString_ShowPlayerInfo()
        {
            //Arrange
            
            var player = new Player();

            //Act
            player.FirstName = "pesho";
            player.LastName = "ivanov";

            //Assert
            StringAssert.Contains("pesho ivanov", player.ToString());

        }
    }
}

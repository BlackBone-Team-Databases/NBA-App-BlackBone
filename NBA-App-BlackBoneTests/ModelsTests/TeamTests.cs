using Moq;
using NbaBlackBone;
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
    class TeamTests
    {
        [Test]
        public void Teams_PropertyId_SetsValueCorrect()
        {
            //Arrange
            var team = new Team();

            //Act
            team.Id = 5;

            //Assert
            Assert.AreEqual(team.Id, 5);

        }

        [Test]
        public void Teams_PropertyMinutes_SetsValueCorrect()
        {
            //Arrange
            var team = new Team();

            //Act
            team.Minutes = 6;

            //Assert
            Assert.AreEqual(team.Minutes, 6);

        }

        [Test]
        public void Teams_PropertyOffRtg_SetsValueCorrect()
        {
            //Arrange
            var team = new Team();

            //Act
            team.OffRtg = 6;

            //Assert
            Assert.AreEqual(team.OffRtg, 6);

        }

        [Test]
        public void Teams_PropertyDeffRtg_SetsValueCorrect()
        {
            //Arrange
            var team = new Team();

            //Act
            team.DeffRtg = 5;

            //Assert
            Assert.AreEqual(team.DeffRtg, 5);

        }

        [Test]
        public void Teams_PropertyDevision_SetsValueCorrect()
        {
            //Arrange
            var Div = new Mock<Devision>();
            var team = new Team();

            //Act
            team.Devision = Div.Object;

            //Assert
            Assert.AreEqual(team.Devision, Div.Object);

        }

        [Test]
        public void Teams_ToString_ShowTeamInfo()
        {
            //Arrange

            var team = new Team();

            //Act
            team.Name = "MyTeam";
            team.OffRtg = 5;

            //Assert
            StringAssert.Contains("MyTeam", team.ToString());
            StringAssert.Contains("5", team.ToString());
        }
    }
}

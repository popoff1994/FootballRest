using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballRest.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FootballRest.Managers.Tests
{
    [TestClass()]
    public class FootballsManagerTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            //Arrange
            FootballsManager footballManager = new FootballsManager();
            //Act
            var playerList = footballManager.GetAll();
            //Assert
            if (playerList.Count > 0)
                Assert.IsTrue(playerList.Count > 0);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            //Arrange
            FootballsManager footballsManager = new FootballsManager();
            int id = 2;
            //Act
            var result = footballsManager.GetById(id);

            //Assert
            Assert.IsNotNull(result.Name);
        }

        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            FootballsManager footballsManager = new FootballsManager();
            FootballPlayerLibrary.Class1 footballPlayer = new FootballPlayerLibrary.Class1(4, "Bob", 24, 4);
            string expectedName = "Bob";
            //Act
            var result = footballsManager.Add(footballPlayer);

            //Assert
            Assert.AreEqual(expectedName, result.Name);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            //Arrange
            FootballsManager footballsManager = new FootballsManager();
            int id = 1;
            string expectedNameToBeDeleted = "Zvonimir";
            //Act
            var result = footballsManager.Delete(id);

            //Assert
            Assert.AreEqual(expectedNameToBeDeleted, result.Name);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            //Arrange
            FootballsManager footballsManager = new FootballsManager();
            FootballPlayerLibrary.Class1 footballPlayer = new FootballPlayerLibrary.Class1(4, "Bob", 24, 4);
            int id = 1;
            string expectedNewName = "Bob";
            //Act
            var result = footballsManager.Update(2, footballPlayer);

            //Assert
            Assert.AreEqual(expectedNewName, result.Name);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTackToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTackToe.Tests
{
    [TestClass()]
    public class tickTackToeTests
    {
        [TestMethod()]
        public void createBoardTest()
        {
            // Arrange
            tickTackToe tick = new tickTackToe();

            //Act
            int x = tick.createBoard();

            //Assert
            Assert.AreEqual(9, x);
        }

        [TestMethod()]
        public void CurrentPlayerTest()
        {
            // Arrange
            tickTackToe tick = new tickTackToe();

            //Act
            char x = tick.CurrentPlayer(0);
            char y = tick.CurrentPlayer(1);
            //Assert
            Assert.AreEqual('x', x);
            Assert.AreEqual('o', y);
        }

        [TestMethod()]
        public void ChangePlayerTest()
        {
            // Arrange
            tickTackToe tick = new tickTackToe();

            //Act
            string x = tick.ChangePlayer(1);
            string y = tick.ChangePlayer(0);
            //Assert
            Assert.AreEqual("player1", x);
            Assert.AreEqual("player2", y);
        }
    }
}
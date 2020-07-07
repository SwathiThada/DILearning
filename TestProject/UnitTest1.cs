using System;
using UnderstandingLINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class SelectBooksTests
    {
        [TestMethod]
        public void IsAvailable_BookisAvailable_ReturnsTrue()
        {
            //Arrange
            var selectBooks = new SelectBooks();

            //Act
            var result = selectBooks.IsAvailable("Wise and Otherwise");

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsAvailable_BookIsNotAvailable_ReturnFalse()
        {
            //Arrage
            var selectBooks = new SelectBooks();
            //Act
            var result = selectBooks.IsAvailable("Little Soldiers");
            //Assert
            Assert.IsFalse(result);

        }
    }
}

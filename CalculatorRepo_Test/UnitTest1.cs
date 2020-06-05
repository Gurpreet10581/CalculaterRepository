using System;
using CalculaterRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorRepo_Test
{
    [TestClass]
    public class UnitTest1
    {   /// setting value to calc_repo belwo from repo file 

        Calculator_Repo calc_repo = new Calculator_Repo();

        [TestMethod]
        public void AddNumbers_Test()
        {
            //Arrange
            int result =calc_repo.AddNamers(2, 3);

            //Act
            // used expected= 5 to check if the method worked or not 
            int expected = 5;
            int actual = result;



            //Assert
            //below testing the above created ACT

            Assert.AreEqual(expected, actual);
            
           
        }

        [TestMethod]
        public void Subtract_Test()
        {
            int result = calc_repo.Subtract(10, 20);
            int expected = -10;
            int actual = result;
            Assert.AreEqual(expected, actual);

        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AutomatedTestingExample;

namespace AutomatedTestingExample.Tests
{
    [TestFixture]
    public class ProgramTest
    {
        static int myExpectedResult;
        static Program p1;

        [SetUp] //code here is executed before tests are executed
        public static void Init()
        {
            p1 = new Program();
        }

        [Test]
        //name = methodName_StateUnderTest_ExpectedBehaviour
        public static void Add_SimpleValues_Calculated_1()
        {
            // AAA patern
            // Arrange
            // Act
            // Assert
            myExpectedResult = 9; //what my code should be returning
            int actualResult = p1.Add(4, 5); //call the method
            Assert.AreEqual(myExpectedResult, actualResult);
        }

        [Test]
        public static void Add_SimpleValues_Calculated_2()
        {
            myExpectedResult = 0; //what my code should be returning
            int actualResult = p1.Add(0, 0);
            Assert.AreEqual(myExpectedResult, actualResult);
        }


        [Test]
        public static void Add_SimpleValues_Calculated_3()
        {
            myExpectedResult = 20;
            int actualResult = p1.Add(2020, -2000);
            Assert.AreEqual(myExpectedResult, actualResult);
        }
    }
}

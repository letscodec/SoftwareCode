using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Grade;

namespace TestClass
{
    public class TestClass
    {
        [TestFixture]
        public class TestClass1
        {
            [Test] 
            public void Grade_ValidGradeOuput88dot8()
            {

                // Arrange
                double numericGrade = 88.8;
               // string correspondingLetterGrade = "A";
                string expected = "88.8";
            
                //Act 
                String actual =numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected,actual);
              


            }
            [Test]
            public void Grade_ValidGradeOutput87dot7()
            {

                // Arrange
                double numericGrade = 87.7;

                string expected = "87.7";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput99dot8()
            {

                // Arrange
                double numericGrade = 99.8;

                string expected = "99.8";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput91dot8()
            {

                // Arrange
                double numericGrade = 91.8;

                string expected = "91.8";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput93dot8()
            {

                // Arrange
                double numericGrade = 93.8;

                string expected = "93.8";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput71dot1()
            {

                // Arrange
                double numericGrade = 71.1;

                string expected = "71.1";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput72dot1()
            {

                // Arrange
                double numericGrade = 72.1;

                string expected = "72.1";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput73dot1()
            {

                // Arrange
                double numericGrade = 73.1;

                string expected = "73.1";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput74dot1()
            {

                // Arrange
                double numericGrade = 74.1;

                string expected = "74.1";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput75dot1()
            {

                // Arrange
                double numericGrade = 75.1;

                string expected = "75.1";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput61dot1()
            {

                // Arrange
                double numericGrade = 61.1;

                string expected = "61.1";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput62dot1()
            {

                // Arrange
                double numericGrade = 62.1;

                string expected = "62.1";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput63dot1()
            {

                // Arrange
                double numericGrade = 63.1;

                string expected = "63.1";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput55dot1()
            {

                // Arrange
                double numericGrade = 55.1;

                string expected = "55.1";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void Grade_ValidGradeOutput45dot1()
            {

                // Arrange
                double numericGrade = 45.1;

                string expected = "45.1";
                //Act 
                String actual = numericGrade.ToString();

                // Assert
                Assert.AreEqual(expected, actual);


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp14;
namespace ClassLibrary1
{
    [TestFixture]
    class Class1
    {


        [Test]

        public void Analyze_Input1and1and7_Returns_DoesnotFormTriangle()
        {
            //Arraange
            int s1 = 1;
            int s2 = 1;
            int s3 = 7;

            string expectedResult = "Doesnot Form Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        [Test]

        public void Analyze_Input4and8and4_Returns_DoesnotFormTriangle()
        {
            //Arraange
            int s1 = 4;
            int s2 = 8;
            int s3 = 4;

            string expectedResult = "Doesnot Form Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        [Test]
        public void Analyze_Input5and5and5_Returns_Equilateral()
        {
            //Arraange
            int s1 = 5;
            int s2 = 5;
            int s3 = 5;

            string expectedResult = "Its is a Triangle\nForms Equilateral Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        [Test]
        public void Analyze_Input9and4and6_Returns_Scalene()
        {
            //Arraange
            int s1 = 9;
            int s2 = 4;
            int s3 = 6;

            string expectedResult = "Its is a Triangle\nForms Scalene Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input8and4and7_Returns_Scalene()
        {
            //Arraange
            int s1 = 8;
            int s2 = 4;
            int s3 = 7;

            string expectedResult = "Its is a Triangle\nForms Scalene Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void Analyze_Input9and9and9_Returns_Equilateral()
        {
            //Arraange
            int s1 = 9;
            int s2 = 9;
            int s3 = 9;

            string expectedResult = "Its is a Triangle\nForms Equilateral Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input2and2and9_Returns_DoesnotFormTriangle()
        {
            //Arraange
            int s1 = 2;
            int s2 = 2;
            int s3 = 9;

            string expectedResult = "Doesnot Form Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input5and2and5_Returns_Isosceles()
        {
            //Arraange
            int s1 = 5;
            int s2 = 2;
            int s3 = 5;

            string expectedResult = "Its is a Triangle\nForms Isosceles Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }


}














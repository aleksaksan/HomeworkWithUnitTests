using NUnit.Framework;
using MySpace;

namespace Homework2.Tests
{
    public class Tests
    {
        HW2 _hw2;
        [SetUp]
        public void Setup()
        {
            _hw2 = new HW2();
        }


        [TestCase(9, 5, "A+B=14")] //if (a > b) 
        [TestCase(0, 0, "A*B=0")] //(a == b) == 0
        [TestCase(2, 2, "A*B=4")] //(a == b) == 0
        [TestCase(5, 5, "A*B=25")]
        [TestCase(5, 11, "A-B=-6")] // a<b

        public void GetAnswerOfTask1Test(int a, int b, string expected)
        {
            //arrange

            //act
            string actual = _hw2.GetAnswerOfTask1(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 11, 1)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, 0, 6)]
        [TestCase(0, 1, 5)]
        [TestCase(-1, 1, 2)]
        [TestCase(-1, -1, 3)]
        [TestCase(1, -1, 4)]
        public void GetIntQuarterTest(int x, int y, int expected)
        {
            //arrange

            //act
            int actual = _hw2.GetIntQuarter(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, -2, -24}, 100.0)]
        [TestCase(new int[] { 42, 0, 0 }, 0.0)]
        [TestCase(new int[] { 1, -6, -7 }, 64.0)]
        [TestCase(new int[] { 1, -2, 1 }, 0.0)]
        public void GetDiscrTest(int[] arr, double expected)
        {
            //arrange

            //act
            double actual = _hw2.GetDiscr(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }
      

        [TestCase(new int[] { 1, -2, -24 }, 100.0, new double[] { 6.0, -4.0 })]
        [TestCase(new int[] { 3, -18, 27 }, 0, new double[] { 3.0 })]
        public void CalculateXTest(int[] arr, double discr, double[] expected)
        //public void CalculateXTest()
        {
            //arrange
            //int[] arr = new int[] { 1, -2, -24};
            //double discr = 100;
            //double[] expected = {6.0, -4.0};
            //act
            double[] actual = _hw2.CalculateX(arr, discr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(11, "одиннадцать")]
        [TestCase(22, "двадцать два")]
        public void GetNumInString(int num, string expected)
        
        {
            //arrange
            
            //act
            string actual = _hw2.GetNumInString(num);
            //assert
            Assert.AreEqual(expected, actual);
        }
       
    }
}
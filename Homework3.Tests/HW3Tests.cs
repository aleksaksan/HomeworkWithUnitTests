using NUnit.Framework;
using MySpace;

namespace Homework3.Tests
{
    public class Tests
    {
        HW3 _hw3;
        [SetUp]
        public void Setup()
        {
            _hw3 = new HW3();
        }

        [TestCase(0, 0, 1)]
        [TestCase(2, 10, 1024)]
        public void MyPowTest(int a, int n, int expected)
        {
            //arrange

            //act
            int actual = HW3.MyPow(a, n);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(10, 3)]
        public void GetCountOfTask3Test(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.GetCountOfTask3(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5)]
        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        public void GetMaxDivisorTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.GetMaxDivisor(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 15, 21)]
        [TestCase(-14, 14, 0)]
        [TestCase(-21, -5, -42)]
        [TestCase(7, 21, 42)]
        public void GetSumDivisorOfSevensInRangeTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw3.GetSumDivisorOfSevensInRange(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(7, 13)]
        public void GetNNumFibTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.GetNNumFib(a);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(54, 24, 6)]
        public void GetGCDTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw3.GetGCD(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 2)]
        public void GetNumByMethOfHalfsDividesTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.GetCoubByMethOfHalfsDivides(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123456789, 5)]
        [TestCase(222222222, 0)]
        [TestCase(-11111111, 8)]
        [TestCase(0, 0)]
        public void GetCountOfOddsTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.GetCountOfOdds(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 321)]
        [TestCase(123456, 654321)]
        public void GetMirrorNumTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.GetMirrorNum(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 2, 4, 6, 8, 12, 14 })]
        public void GetNumsOfTask11Test(int a, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw3.GetNumsOfTask11(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(123, 3456789, "дю")]
        [TestCase(666, 999, "мер")]
        public void SayYesIfNumbersGotEqualsDigitsTest(int a, int b, string expected)
        {
            //arrange

            //act
            string actual = _hw3.SayYesIfNumbersGotEqualsDigits(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
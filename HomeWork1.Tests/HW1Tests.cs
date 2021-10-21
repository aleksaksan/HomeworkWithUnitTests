using NUnit.Framework;
using MySpace;

namespace HomeWork1.Tests
{
    public class Tests
    {
        HW1 _hw1;
        [SetUp]
        public void Setup()
        {
            _hw1 = new HW1();
        }

        //[Test]
        //public void GetResultTest()
        //{
        //    //arrange
        //    double a = 5;
        //    double b = 9;
        //    double expected = 26.5;
        //    //act
        //    double actual = _hw1.GetResult(a, b);
        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}

        [TestCase(5,9, 26.5)]
        [TestCase(0, 0, 0)]
        [TestCase(5, 5, 0)]

        public void GetResultTest(double a, double b, double expected)
        {
            //arrange
            
            //act
            double actual = _hw1.GetResult(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /////////
        ///$"результат деления A на B: { numA / numB}\nостаток от деления: { numA % numB}"
        ///
        [TestCase(10, 0, "на ноль делить нельзя!")]
        [TestCase(10, 10, "результат деления A на B: 1\nостаток от деления: 0")]
        [TestCase(11, 5, "результат деления A на B: 2\nостаток от деления: 1")]

        public void DoCalcTest(int a, int b, string expected)
        {
            //arrange

            //act
            string actual = _hw1.DoCalc(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        //(numC - numB) / numA;
        [TestCase(10, 10, 10, 0)]
        [TestCase(0, 11, 11, double.NaN)]
        [TestCase(2, 5, 10, 2.5)]
        public void GetXTest(int a, int b, int c, double expected)
        {
            //arrange

            //act
            double actual = _hw1.GetX(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        //(Y2 - Y1) / (X2 - X1);
        [TestCase(2, 21, 2, 2.5, double.NaN)]
        [TestCase(1, 10, 5, 20, 2.5)]
        public void GetATask5(double a, double b, double c, double d, double expected)
        {
            //arrange

            //act
            double actual = _hw1.GetATask5(a, b, c, d);
            //assert
            Assert.AreEqual(expected, actual);
        }


        // (Y1 - X1 * (Y2 - Y1) / (X2 - X1))
        [TestCase(2, 21, 2, 2.5, double.NaN)]
        [TestCase(1, 10, 5, 20, 7.5)]  // 10 - 1 * 10/4
        public void GetBTask5(double a, double b, double c, double d, double expected)
        {
            //arrange

            //act
            double actual = _hw1.GetBTask5(a, b, c, d);
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
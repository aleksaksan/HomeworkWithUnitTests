using NUnit.Framework;
using MySpace;
namespace Homework5.Tests
{
    public class Tests
    {
        HW5 _hw;
        [SetUp]
        public void Setup()
        {
            _hw = new HW5();
        }
        

        [TestCase(0, -1)]
        [TestCase(1, -2)]
        [TestCase(2, -22)]
        [TestCase(3, 0)]
        [TestCase(-1, 0)]
        public void GetMinFromArrTest(int arrayIndex, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForGetMinFromArrTest(arrayIndex);

            //act
            int actual = _hw.GetMinFromArr(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 2)]
        [TestCase(-1, 0)]
        public void GetMaxOfArrTest(int arrayIndex, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForGetMinFromArrTest(arrayIndex);

            //act
            int actual = _hw.GetMaxOfArr(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 1, 0 })]
        [TestCase(1, new int[] { 0, 1 })]
        [TestCase(2, new int[] { 1, 1 })]
        [TestCase(3, new int[] { 0, 2 })]
        [TestCase(-1, new int[] { 0, 0})]
        public void GetIndexOfMinTest(int arrayIndex, int[] expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForGetMinFromArrTest(arrayIndex);

            //act
            int[] actual = _hw.GetIndexOfMin(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 0, 0 })]
        [TestCase(1, new int[] { 1, 1 })]
        [TestCase(2, new int[] { 0, 2 })]
        [TestCase(3, new int[] { 0, 1 })]
        [TestCase(-1, new int[] { 0, 0 })]
        public void GetIndexOfMaxTest(int arrayIndex, int[] expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForGetMinFromArrTest(arrayIndex);

            //act
            int[] actual = _hw.GetIndexOfMax(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(0, 5)]
        public void CountOfBiggersTest(int arrayIndex, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForCountOfBiggersTest(arrayIndex);

            //act
            int actual = _hw.CountOfBiggers(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        public void DoMirrorMatrixTest(int arrayIndex)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForDoMirrorMatrixTest(arrayIndex);
            int[,] expected = TestData.GetExpectedArrayForDoMirrorMatrixTest(arrayIndex);
            //act
            _hw.DoMirrorMatrix(arrayToTest);
            //assert
            Assert.AreEqual(expected, arrayToTest);
        }
        

    }
}
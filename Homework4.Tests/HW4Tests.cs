using NUnit.Framework;
using MySpace;

namespace Homework4.Tests
{
    public class Tests
    {
        HW4 _hw;
        [SetUp]
        public void Setup()
        {
            _hw = new HW4();
        }

        [TestCase(new int[] { 22, 4, 6, 8, 12, 14 }, 4)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, -4, 6, 8, -12, 14 }, -12)]
        public void FindMinTest(int[] arr, int expected)
        {
            //arrange

            //act
            int actual = _hw.FindMin(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 22, 4, 6, 8, 12, 14 }, 22)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, -4, 6, 8, -12, 14 }, 14)]
        public void FindMaxTest(int[] arr, int expected)
        {
            //arrange

            //act
            int actual = _hw.FindMax(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 22, 4, 6, 8, 12, 14 }, 1)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, -4, 6, 8, -12, 14 }, 4)]
        public void FindIndexOfMinTest(int[] arr, int expected)
        {
            //arrange

            //act
            int actual = _hw.FindIndexOfMin(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 22, 4, 6, 8, 12, 14 }, 26)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, -4, 6, 8, -12, 14 }, 18)]
        public void GetCountOddsIndexTest(int[] arr, int expected)
        {
            //arrange

            //act
            int actual = _hw.GetCountOddsIndex(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(new int[] { 1,2,3,4 }, new int[] { 4,3,2,1 })]
        [TestCase(new int[] { 1,2,3,4,5 }, new int[] { 5,4,3,2,1 })]
        public void ReverseArrTest(int[] arr, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw.ReverseArr(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(new int[] { 1, 2, 3, 4 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new int[] { 0 }, 0)]
        public void GetCountOddsTest(int[] arr, int expected)
        {
            //arrange

            //act
            int actual = _hw.GetCountOdds(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
        public void ChangeHalvesTest(int[] arr, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw.ChangeHalves(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 5, 1, 3, 2, 4 }, new int[] { 1, 2, 3, 4, 5 })]
        public void InsertSortTest(int[] arr, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw.InsertSort(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 5, 1, 3, 2, 4 }, new int[] { 5, 4, 3, 2, 1 })]
        public void SortBackTest(int[] arr, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw.SortBack(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
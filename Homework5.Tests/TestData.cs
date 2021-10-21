using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpace
{
    public class TestData
    {
        public static int[,] GetArrayForGetMinFromArrTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1 }, { -1 } },
                1 => new int[,] { { 1, -2 }, { 1, 2 } },
                2 => new int[,] { { 1, 2, 3 }, { 1, -22, 3 }, { 3, 2, 1 } },
                3 => new int[,] { { 1, 2, 0 } },
                _ => new int[,] { { 0 } }
            };
        }

        public static int[,] GetArrayForCountOfBiggersTest(int index)
        {
            return index switch
            {
                0 => new int[,] 
                { 
                    { 0, 1, 0, 0, 1 }, 
                    { 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 1 },
                    { 0, 0, 1, 0, 0 },
                },
                _ => new int[,] { { } }
            };
        }

        public static int[,] GetArrayForDoMirrorMatrixTest(int index)
        {
            return index switch
            {
                0 => new int[,] 
                { 
                    { 1, -2 }, 
                    { 1, 2 } 
                },
                1 => new int[,] 
                { 
                    { 1, 22, 33 }, 
                    { 11, 1, 44 }, 
                    { 55, 66, 1 } 
                },
                _ => new int[,] { { 0 } }
            };
        }
        public static int[,] GetExpectedArrayForDoMirrorMatrixTest(int index)
        {
            return index switch
            {
                0 => new int[,]
                {
                    { 1, 1 },
                    { -2, 2 }
                },
                1 => new int[,]
                {
                    { 1, 11, 55 },
                    { 22, 1, 66 },
                    { 33, 44, 1 }
                },
                _ => new int[,] { { 0 } }
            };
        }
    }
}

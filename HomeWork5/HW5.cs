using System;

namespace MySpace
{
    public class HW5
    {
        Core.CoreClass cc = new Core.CoreClass();


        // task1
        public void SolveTask1()
        {
            Console.WriteLine("Найти минимальный элемент массива");

            int[,] myArr = cc.InitDArr();

            Console.WriteLine($"минимальный элемент массива равен {GetMinFromArr(myArr)}");
        }
        public int GetMinFromArr(int[,] arr)
        {
            int minValue = arr[0, 0];
            foreach (var item in arr)
            {
                if (minValue > item)
                    minValue = item;
            }
            return minValue;
        }
        // task2
        public void SolveTask2()
        {
            Console.WriteLine("Найти максимальный элемент массива");

            int[,] myArr = cc.InitDArr();
            
            Console.WriteLine($"максимальный элемент массива равен {GetMaxOfArr(myArr)}");
        }
        public int GetMaxOfArr(int[,] arr)
        {
            int maxValue = arr[0, 0];
            foreach (var item in arr)
            {
                if (maxValue < item)
                    maxValue = item;
            }
            return maxValue;
        }
        // task3

        public void SolveTask3()
        {
            Console.WriteLine("Найти индекс минимального элемента массива");

            int[,] myArr = cc.InitDArr();
            int[] index = GetIndexOfMin(myArr);
            Console.WriteLine($"индекс (первого) минимального элемента массива равен [{index[0]}, {index[1]}]");
        }
        public int[] GetIndexOfMin(int[,] arr)
        {
            int minValue = arr[0, 0];
            int[] index = new int[2];
            

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (minValue > arr[i, j])
                    {
                        minValue = arr[i, j];
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
            return index;
        }
        //task4
        public void SolveTask4()
        {
            Console.WriteLine("Найти индекс максимального элемента массива");

            int[,] myArr = cc.InitDArr();
            
            int[] index = GetIndexOfMax(myArr);
            Console.WriteLine($"индекс (первого) максимального элемента массива равен [{index[0]},{index[0]}]");
        }
        public int[] GetIndexOfMax(int[,] arr)
        {
            int maxValue = arr[0, 0];
            int[] index = new int[2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (maxValue < arr[i, j])
                    {
                        maxValue = arr[i, j];
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
            return index;
        }


        // task5
        public void SolveTask5()
        {
            Console.WriteLine("Найти количество элементов массива, которые больше всех своих соседей одновременно");

            int[,] myArr = cc.InitDArr();
            

            Console.WriteLine($"количество элементов массива, которые больше всех своих соседей одновременно: {CountOfBiggers(myArr)}");
        }
        public int CountOfBiggers(int[,] myArr)
        {
            int resCounter = 0;

            for (int i = 1; i < myArr.GetLength(0) - 1; i++)    //без крайних столбцов и строчек
            {
                for (int j = 1; j < myArr.GetLength(1) - 1; j++)
                {
                    if (myArr[i, j] > myArr[i - 1, j - 1] && myArr[i, j] > myArr[i + 1, j + 1]
                        && myArr[i, j] > myArr[i, j - 1] && myArr[i, j] > myArr[i - 1, j])
                        resCounter++;
                }
            }
            for (int j = 1; j < myArr.GetLength(1) - 1; j++)    // для верхней строки без последнего элемента 
                if (myArr[0, j] > myArr[0, j + 1] && myArr[0, j] > myArr[0, j - 1] && myArr[0, j] > myArr[1, j])
                    resCounter++;

            for (int i = 1; i < myArr.GetLength(0) - 1; i++)    // для левого столбца без последнего элемента 
                if (myArr[i, 0] > myArr[i + 1, 0] && myArr[i, 0] > myArr[i - 1, 0] && myArr[i, 0] > myArr[i, 1])
                    resCounter++;

            for (int j = 1; j < myArr.GetLength(1) - 1; j++)    // для нижней строки без последнего элемента 
                if (myArr[myArr.GetLength(0) - 1, j] > myArr[myArr.GetLength(0) - 1, j + 1]
                    && myArr[myArr.GetLength(0) - 1, j] > myArr[myArr.GetLength(0) - 1, j - 1]
                    && myArr[myArr.GetLength(0) - 1, j] > myArr[myArr.GetLength(0) - 2, j])
                    resCounter++;

            for (int i = 1; i < myArr.GetLength(0) - 1; i++)    // для правого столбца без последнего элемента 
                if (myArr[i, myArr.GetLength(1) - 1] > myArr[i + 1, myArr.GetLength(1) - 1]
                    && myArr[i, myArr.GetLength(1) - 1] > myArr[i - 1, myArr.GetLength(1) - 2]
                    && myArr[i, 0] > myArr[i, 1])
                    resCounter++;

            // левый верхний угол
            if (myArr[0, 0] > myArr[1, 0] && myArr[0, 0] > myArr[0, 1])
                resCounter++;

            // правый верхний угол
            if (myArr[0, myArr.GetLength(1) - 1] > myArr[1, myArr.GetLength(1) - 1]
                && myArr[0, myArr.GetLength(1) - 1] > myArr[0, myArr.GetLength(1) - 2])
                resCounter++;

            // левый нижний угол
            if (myArr[myArr.GetLength(0) - 1, 0] > myArr[myArr.GetLength(0) - 1, 1]
                && myArr[myArr.GetLength(0) - 1, 0] > myArr[myArr.GetLength(0) - 2, 0])
                resCounter++;

            // правый нижний угол
            if (myArr[myArr.GetLength(0) - 1, myArr.GetLength(1) - 1] > myArr[myArr.GetLength(0) - 2, myArr.GetLength(1) - 1]
                && myArr[myArr.GetLength(0) - 1, myArr.GetLength(1) - 1] > myArr[myArr.GetLength(0) - 1, myArr.GetLength(1) - 2])
                resCounter++;
            return resCounter;
        }
        // task 6
        public void SolveTask6()
        {
            Console.WriteLine("Отразите массив относительно его главной диагонали");

            int[,] myArr = GetAndPrintSquareMatrix();
            DoMirrorMatrix(myArr);
            PrintMatrix(myArr);

        }
        void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(0); j++)
                    Console.Write(arr[i, j]+ "\t");
            Console.WriteLine();
        }
        public void DoMirrorMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (i > j)
                    {
                        cc.MySwap(ref arr[i, j], ref arr[j, i]);
                    }
                }
        }
        int[,] GetAndPrintSquareMatrix()
        {
            Console.WriteLine("Введите размерность двумерного массива NxN");
            int nDimention = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[,] arr = new int[nDimention, nDimention];
            Console.WriteLine("исходный массив: ");
            for (int i = 0; i < nDimention; i++)
            {
                for (int j = 0; j < nDimention; j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return arr;
        }
    }
}

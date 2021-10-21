using System;


namespace Core
{
    public class CoreClass
    {
        //ввод данных
        #region ввод данных
        public double GetDoubleNumFromUser(string msg)
        {
            Console.Write(msg);
            return double.Parse(Console.ReadLine());
        }
        public int GetIntNumFromUser(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
        public string GetStringFromUser(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        /// <summary>
        /// Запрос на ввод нескольких параметров типа int
        /// </summary>
        /// <param name="numOfRequests">количество запросов на ввод</param>
        /// <param name="symbol">символ, с которого начинается перечисление</param>
        /// <returns></returns>
        public int[] GetIntArrFromUser(int numOfRequests, char symbol)
        {
            int[] arr = new int[numOfRequests];
            for (int i = 0; i < numOfRequests; i++)
            {
                arr[i] = GetIntNumFromUser($"Введите {(char)(symbol + i)}: ");
            }
            return arr;
        }
        #endregion
        //

        public void MySwap<T>(ref T a, ref T b) //swap
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public void MyBubbleSort(int[] arr) //sort
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        MySwap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
        public int[] InitArr(int from, int to, int size) //инициализация массива и вывод на экран
        {
            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(from, to);
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            return arr;
        }
        public int[,] InitDArr()
        {
            Console.WriteLine("Введите размерность двумерного массива MxN");
            int mDimention = GetIntNumFromUser("M = ");
            int nDimention = GetIntNumFromUser("N = ");

            Random rnd = new Random();
            int[,] arr = new int[mDimention, nDimention];
            for (int i = 0; i < mDimention; i++)
                for (int j = 0; j < nDimention; j++)
                    arr[i, j] = rnd.Next(-10, 10);

            for (int i = 0; i < mDimention; i++)
            {
                for (int j = 0; j < nDimention; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return arr;
        }
        public void PrintArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
}

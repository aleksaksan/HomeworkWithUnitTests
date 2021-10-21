using System;

namespace MySpace
{
    public class HW4
    {
        Core.CoreClass cc = new Core.CoreClass();
       
        // task 1
        public void SolveTask1()
        {
            Console.WriteLine("Найти минимальный элемент массива");
            int size = cc.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = cc.InitArr(-10, 10, size);
            Console.WriteLine($"минимальный элемент массива равен {FindMin(myArr)}");
        }
        public int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            return min;
        }
        // task 2
        public void SolveTask2()
        {
            Console.WriteLine("Найти максимальный элемент массива");
            int size = cc.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = cc.InitArr(-10, 10, size);
            

            Console.WriteLine($"максимальный элемент массива равен {FindMax(myArr)}");
        }
        public int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            return max;
        }
        // task 3
        public void SolveTask3()
        {
            Console.WriteLine("Найти индекс минимального элемента массива");
            int size = cc.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = cc.InitArr(-10, 10, size);

            
            Console.WriteLine($"индекс минимального элемента: {FindIndexOfMin(myArr)}");
        }
        public int FindIndexOfMin(int[] arr)
        {
            int min = arr[0];
            int indexOfMin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    indexOfMin = i;
                    min = arr[i];
                }
            }
            return indexOfMin;
        }
        //task 4
        public void SolveTask4()
        {
            Console.WriteLine("Найти индекс максимального элемента массива");
            int size = cc.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = cc.InitArr(-10, 10, size);
           

            Console.WriteLine($"индекс максимального элемента: {FindIndexOfMax(myArr)}");
        }
        public int FindIndexOfMax(int[] arr)
        {
            int max = arr[0];
            int indexOfMax = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    indexOfMax = i;
                    max = arr[i];
                }
            }
            return indexOfMax;
        }
        // task 5
        public void SolveTask5()
        {
            Console.WriteLine("Посчитать сумму элементов массива с нечетными индексами");
            int size = cc.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = cc.InitArr(-10, 10, size);
            
            Console.WriteLine($"Сумма элементов с нечётными индексами: {GetCountOddsIndex(myArr)}");
        }
        public int GetCountOddsIndex(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                sum += arr[i];
            }
            return sum;
        }
        // task 6
        public void SolveTask6()
        {
            Console.WriteLine("Сделать реверс массива (массив в обратном направлении)");
            int size = cc.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = cc.InitArr(-10, 10, size);
            ReverseArr(myArr);
            PrintArr(myArr);
        }
        public int[] ReverseArr(int[] arr) // для тетса
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                cc.MySwap(ref arr[i], ref arr[(arr.Length - 1) - i]);
            }
            return arr;
        }
        //void ReverseArr(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length / 2; i++)
        //    {
        //        cc.MySwap(ref arr[i], ref arr[(arr.Length - 1) - i]);
        //    }
        //}

        /////////////
        ///вывод массива
        private void PrintArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
        ///////////////
        ///

        //task 7
        public void SolveTask7()
        {
            Console.WriteLine("Посчитать количество нечетных элементов массива");
            int size = cc.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = cc.InitArr(-10, 10, size);
            
            Console.WriteLine($"количество нечётных элементов : {GetCountOdds(myArr)}");
        }
        public int GetCountOdds(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    counter++;
            }
            return counter;
        }
        //task 8
        public void SolveTask8()
        {
            Console.WriteLine("Поменять местами первую и вторую половину массива, например,\n" +
                "для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.");
            int size = cc.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = cc.InitArr(-10, 10, size);
            ChangeHalves(myArr);
            PrintArr(myArr);
        }
        public int[] ChangeHalves(int[] arr) // для теста
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                cc.MySwap(ref arr[i], ref arr[i + arr.Length / 2 + arr.Length % 2]);
            }
            return arr;
        }
        //void ChangeHalves(int[] arr) 
        //{
        //    for (int i = 0; i < arr.Length / 2; i++)
        //    {
        //        cc.MySwap(ref arr[i], ref arr[i + arr.Length / 2 + arr.Length % 2]);
        //    }
        //}
        // task 9
        public void SolveTask9()
        {
            Console.WriteLine("Отсортировать массив по возрастанию одним из способов:\n" +
                "пузырьком(Bubble), выбором (Select) или вставками (Insert))");
            int size = cc.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = cc.InitArr(-10, 10, size);

            InsertSort(myArr);
            Console.WriteLine("отсортированный массив: ");
            PrintArr(myArr);
        }
        public int[] InsertSort(int[] arr) // для теста
        {
            // сортировка вставками

            int temp;
            int j;

            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                j = i - 1;
                for (j = i - 1; j >= 0 && arr[j] > temp; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = temp;
            }
            return arr;
        }
        // task 10
        public void SolveTask10()
        {
            Console.WriteLine("Отсортировать массив по убыванию одним из способов,\n" +
                "(отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором (Select) или вставками (Insert))");
            int size = cc.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = cc.InitArr(-10, 10, size);
            SortBack(myArr);
            PrintArr(myArr);
        }
        public int[] SortBack(int[] arr)
        {
            // bubble sort

            for (int j = 0; j < arr.Length; j++)
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    if (arr[i] > arr[i - 1])
                    {
                        cc.MySwap(ref arr[i - 1], ref arr[i]);
                    }
                }
            return arr;
        }
    }
}

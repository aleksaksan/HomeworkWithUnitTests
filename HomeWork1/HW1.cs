using System;
using Core;

namespace MySpace
{
    public class HW1
    {
        CoreClass cc = new CoreClass();

        // task 1
        public void SolveTask1 ()
        {
            Console.WriteLine("Пользователь вводит 2 числа (A и B). Выведите в консоль решение\n");
            double numA = cc.GetDoubleNumFromUser("Введите число A: ");
            double numB = cc.GetDoubleNumFromUser("Введите число B: ");
            double result = GetResult(numA, numB);
            Console.WriteLine("result = " + result);
            Console.ReadKey();
        }

        public double GetResult(double numA, double numB)
        {
            if (numA == numB || numA == 0 && numB == 0) return 0;
            double result = (5 * numA + Math.Pow(numB, 2)) / (numB - numA);
            return result;
        }

        // task 2
        public void SolveTask2()
        {
            Console.WriteLine("Пользователь вводит 2 строковых значения(A и B).\nПоменяйте содержимое переменных A и B местами.\n");
            string str1 = cc.GetStringFromUser("Введите первую строку: ");
            string str2 = cc.GetStringFromUser("Введите вторую строку: ");
            cc.MySwap(ref str1, ref str2);
            Console.WriteLine("строка A после изменений: \t" + str1);
            Console.WriteLine("строка B после изменений: \t" + str2);
            Console.ReadKey();
        }
        // task 3
        public void SolveTask3()
        {
            Console.WriteLine("Пользователь вводит 2 числа (A и B).\n" +
                "Выведите в консоль результат деления A на B и остаток от деления.\n");
            int numA = cc.GetIntNumFromUser("Введите число А: ");
            int numB = cc.GetIntNumFromUser("Введите число B: ");
            Console.WriteLine(DoCalc(numA, numB)); 
            Console.ReadKey();
        }
        public string DoCalc(int numA, int numB)
        {
            if (numB != 0)
            {
                return ($"результат деления A на B: { numA / numB}\nостаток от деления: { numA % numB}");
            }
            else
            {
                return "на ноль делить нельзя!";
            }
        }
        // task 4
        public void SolveTask4()
        {
            Console.WriteLine("Пользователь вводит 3 не равных 0 числа (A, B и С).\n" +
                "Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.\n");
            int numA = cc.GetIntNumFromUser("Введите число А: ");
            int numB = cc.GetIntNumFromUser("Введите число B: ");
            int numC = cc.GetIntNumFromUser("Введите число C: ");
            Console.WriteLine();
            if (GetX(numA, numB, numC) != double.NaN)
                Console.WriteLine($"A*X+B=C\nX = {GetX(numA, numB, numC)}");
            else Console.WriteLine("нет корней");
            Console.ReadKey();
        }
        public double GetX(int numA, int numB, int numC)
        {
            if (numA == 0) return double.NaN;
            return (numC - numB) / (double)numA;
        }
        //task 5
        public void SolveTask5()
        {
            Console.WriteLine("Пользователь вводит 4 числа (X1, Y1, X2, Y2), " +
                "описывающие координаты 2-х точек на координатной плоскости.\n" +
                "Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.\n");
            double X1 = cc.GetDoubleNumFromUser("Введите число X1: ");
            double Y1 = cc.GetDoubleNumFromUser("Введите число Y1: ");
            double X2 = cc.GetDoubleNumFromUser("Введите число X2: ");
            double Y2 = cc.GetDoubleNumFromUser("Введите число Y2: ");
            Console.WriteLine("Y=AX+B:");
            double A = GetATask5(X1, Y1, X2, Y2);
            double B = GetBTask5(X1, Y1, X2, Y2);
            if (GetATask5(X1, Y1, X2, Y2) != double.NaN)
                Console.WriteLine("Уравнение прямой нельзя составить");
            else
            {
                if (B > 0)
                    Console.WriteLine("Y=" + A + "X+" + B);
                else if
                    (B == 0) Console.WriteLine("Y=" + A + "X");
                else
                    Console.WriteLine("Y=" + A + "X" + B);
            }
            Console.ReadKey();
        }
        public double GetATask5(double X1, double Y1, double X2, double Y2)
        {
            if (X1 == X2) return double.NaN;
            return (Y2 - Y1) / (X2 - X1);
        }
        public double GetBTask5(double X1, double Y1, double X2, double Y2)
        {
            if (X1 == X2) return double.NaN;
            return (Y1 - X1 * (Y2 - Y1) / (X2 - X1));
        }



    }
}

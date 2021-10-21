using System;

namespace MySpace
{
    public class HW2
    {
        
        Core.CoreClass cc = new Core.CoreClass();
        //task 1
        public void SolveTask1()
        {
            Console.WriteLine("Пользователь вводит 2 числа (A и B). Если A>B, " +
                "подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.\n");
            int numA = cc.GetIntNumFromUser("Введите число А: ");
            int numB = cc.GetIntNumFromUser("Введите число А: ");
            Console.WriteLine(GetAnswerOfTask1(numA, numB));
            Console.ReadKey();
        }
        public string GetAnswerOfTask1(int a, int b)
        {
            if (a > b) 
                return $"A+B={a + b}";
            else if (a == b) 
                return$"A*B={a * b}";
            else 
                return $"A-B={a - b}";
        }
        //task 2
        public void SolveTask2()
        {
            Console.WriteLine("Пользователь вводит 2 числа (X и Y).\n" +
                "Определить какой четверти принадлежит точка с координатами (X,Y).");
            
            int numX = cc.GetIntNumFromUser("Введите X: ");
            int numY = cc.GetIntNumFromUser("Введите Y: ");
            int result = GetIntQuarter(numX, numY);
            Console.WriteLine(ShowQuarter(result));
            
        }
        public int GetIntQuarter(int numX, int numY)
        {
            if (numX > 0 && numY > 0)
                return 1;
            else if (numX < 0 && numY > 0)
                return 2;
            else if (numX < 0 && numY < 0)
                return 3;
            else if (numX > 0 && numY < 0)
                return 4;
            else if (numX == 0 && numY == 0)
                return 0;
            else if (numX == 0)
                return 5;
            else if (numY == 0)
                return 6;
            else return int.MinValue;
        }
        public string ShowQuarter(int res)
        {
            return res switch
            {
                0 => "точка находится на оси Y",
                1 => "Точка с координатами находится в I четверти",
                2 => "Точка с координатами находится в II четверти",
                3 => "Точка с координатами находится в III четверти",
                4 => "Точка с координатами находится в IV четверти",
                5 => "точка находится на оси X",
                6 => "точка находится на оси Y",
                _ => "Something wents wrong"
            };
        }
        

        //task 3
        public void SolveTask3()
        {
            Console.WriteLine("Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.");
            int[] myArr = cc.GetIntArrFromUser(3, 'A');
            cc.MyBubbleSort(myArr);
            foreach (int item in myArr)
            {
                Console.Write(item+ "\t");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        
        
        // task 4
        public void SolveTask4()
        {
            Console.WriteLine("Пользователь вводит 3 числа (A, B и С).\n" +
                "Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.");
            int[] myArr = cc.GetIntArrFromUser(3, 'A');
            Console.WriteLine("AX2+BX+C=0");
            double discr = GetDiscr(myArr);
            double[] ResArray = CalculateX(myArr, discr);
            PrintResult(ResArray, discr);
        }
        void PrintResult(double[] arr, double discr)
        {
            if (discr < 0)
                Console.WriteLine("нет действительных корней");
            else if (discr == 1)
                Console.WriteLine("X = " + arr[0]);
            else
            {
                Console.WriteLine($"X1 = {arr[0]} X2 = {arr[1]}");
            }
        }
        public double[] CalculateX(int[] arr, double discr)
        {
            double[] res = new double[1];
            if (discr > 0)
            {
                res = new double[2];
                res[0] = (-arr[1] + Math.Sqrt(discr)) / 2 / arr[0];
                res[1] = (-arr[1] - Math.Sqrt(discr)) / 2 / arr[0];
            }
            else if (discr == 0)
                res[0] = -arr[1] / 2 / arr[0];
            return res;
        }
        public double GetDiscr(int[] arr)
        {
            return arr[1] * arr[1] - 4 * arr[0] * arr[2];
        }
        //task 5
        public void SolveTask5()
        {
            Console.WriteLine("Пользователь вводит двузначное число.\n " +
                "Выведите в консоль прописную запись этого числа.\n" +
                "Например при вводе “25” в консоль будет выведено “двадцать пять”.");
            int num = cc.GetIntNumFromUser("Введите двузначное число: ");
            Console.WriteLine(GetNumInString(num));
        }
        public string GetNumInString(int num)
        {
            string result = "";
            string secondWord = "";
                if (num < 20)
                {

                switch (num)
                    {
                        case 11:
                            {
                            result = "одиннадцать";
                                break;
                            }
                        case 12:
                            {
                                result = "двенадцать";
                                break;
                            }
                        case 13:
                            {
                                result = "тринадцать";
                                break;
                            }
                        case 14:
                            {
                                result = "четырнадцать";
                                break;
                            }
                        case 15:
                            {
                                result = "пятнадцать";
                                break;
                            }
                        case 16:
                            {
                            result = "шестнадцать";
                                break;
                            }
                        case 17:
                            {
                                result = "семнадцать";
                                break;
                            }
                        case 18:
                            {
                                result = "восемнадцать";
                                break;
                            }
                        case 19:
                            {
                                result = "девятнадцать";
                                break;
                            }
                        default:
                            {
                                result = "something wents wrong";
                                break;
                            }
                    }
                return result;
                }
                else
                {
                    switch (num / 10)
                    {
                        case 2:
                            {
                            result = "двадцать";
                                break;
                            }
                        case 3:
                            {
                            result = "тридцать";
                                break;
                            }
                        case 4:
                            {
                            result = "сорок";
                                break;
                            }
                        case 5:
                            {
                            result = "пятьдесят";
                                break;
                            }
                        case 6:
                            {
                            result = "шестьдесят";
                                break;
                            }
                        case 7:
                            {
                            result = "семдесят";
                                break;
                            }
                        case 8:
                            {
                            result = "восемдесят";
                                break;
                            }
                        case 9:
                            {
                            result = "девяносто";
                                break;
                            }
                    }
                    switch (num % 10)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            secondWord = "один";
                            break;
                        }
                    case 2:
                        {
                            secondWord = ("два");
                            break;
                        }
                    case 3:
                        {
                            secondWord = "три";
                            break;
                        }
                    case 4:
                        {
                            secondWord = "четыре";
                            break;
                        }
                    case 5:
                        {
                            secondWord = "пять";
                            break;
                        }
                    case 6:
                        {
                            secondWord = "шесть";
                            break;
                        }
                    case 7:
                        {
                            secondWord = "семь";
                            break;
                        }
                    case 8:
                        {
                            secondWord = "восемь";
                            break;
                        }
                    case 9:
                        {
                            secondWord = "девять";
                            break;
                        }

                    default:
                        break;
                }
                }
            
            return result + " " + secondWord;
        }
    }
}

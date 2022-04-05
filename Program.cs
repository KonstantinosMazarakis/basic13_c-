using System;

namespace basic13_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
            Console.WriteLine("-------------------------");
            PrintOdds();
            Console.WriteLine("-------------------------");
            PrintSum();
            Console.WriteLine("-------------------------");
            int[] numArray2 = { 1, 2, 3, 4, 6 };
            LoopArray(numArray2);
            Console.WriteLine("-------------------------");
            int[] numArray3 = { 1, 22, -4, 0, 6 };
            FindMax(numArray3);
            Console.WriteLine("-------------------------");
            int[] numArray4 = { 2, 10, 3 };
            GetAverage(numArray4);
            Console.WriteLine("-------------------------");
            OddArray();
            Console.WriteLine("-------------------------");
            int[] numArray5 = { 1, 3, 5, 7 };
            GreaterThanY(numArray5, 3);
            Console.WriteLine("-------------------------");
            int[] numArray6 = { 1, 5, 10, -10 };
            SquareArrayValues(numArray6);
            Console.WriteLine("-------------------------");
            int[] numArray7 = { 1, 5, 10, -2 };
            EliminateNegatives(numArray7);
            Console.WriteLine("-------------------------");
            int[] numArray8 = { 1, 5, 10, -2 };
            MinMaxAverage(numArray8);
            Console.WriteLine("-------------------------");
            int[] numArray9 = { 1, 5, 10, 7, -2 };
            ShiftValues(numArray9);
            Console.WriteLine("-------------------------");
            int[] numArray10 = { -1, -3, 2};
            NumToString(numArray10);
        }

        public static void PrintNumbers()
        {
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }


        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum = sum + i;
                Console.WriteLine("The number is = " + i + "and Sum is = " + sum);
            }
        }


        public static void LoopArray(int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }



        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int i in numbers)
            {
                if (max > i)
                {
                    max = i;
                }
            }
            Console.WriteLine(max);
            return max;
        }



        public static void GetAverage(int[] numbers)
        {
            int avrge;
            int temp = 0;
            foreach (int i in numbers)
            {
                temp = temp + i;
            }
            avrge = temp / numbers.Length;
            Console.WriteLine(avrge);
        }



        public static int[] OddArray()
        {
            int[] arr = new int[255];
            int num = 0;
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                    arr[num] = i;
                    Console.WriteLine(arr[num]);
                }
                num++;
            }

            return arr;
        }


        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            foreach (int i in numbers)
            {
                if (i > y)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }



        public static void SquareArrayValues(int[] numbers)
        {
            int count = 0;
            foreach (int i in numbers)
            {
                numbers[count] = i * i;
                count++;
            }
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }

        }


        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }



        public static void MinMaxAverage(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int temp = 0;
            int avrge;
            foreach (int i in numbers)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
                temp = temp + i;
            }
            avrge = temp / numbers.Length;
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Average: " + avrge);
        }



        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i + 1 != numbers.Length)
                {
                    numbers[i] = numbers[i + 1];
                }
                else
                {
                    numbers[i] = 0;
                    i++;
                }
            }
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }
        }



        public static object[] NumToString(int[] numbers)
        {
            object[] newArr = new object[numbers.Length];
            for(int i = 0; i < numbers.Length;i++)
            {
                if(numbers[i] < 0)
                {
                    newArr[i] = "Dojo";
                }
                else
                {
                    newArr[i] = numbers[i];
                }
                }
                foreach(var x in newArr)
                {
                    Console.WriteLine(x);
                }
                return newArr;
            }
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
        }
    }

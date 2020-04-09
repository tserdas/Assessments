using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assessments
{
    public class Methods
    {
        public static List<List<int>> FindClosestArea(int total, int[,] alllocations, int number)
        {
            List<List<int>> arraytolist = new List<List<int>>();
            List<List<int>> result = new List<List<int>>();
            List<List<double>> calculated = new List<List<double>>();
            for (int i = 0; i < alllocations.GetLength(0); i++)
            {
                List<int> temp = new List<int>(alllocations.GetLength(1));
                int z = 0;
                for (int n = 0; n < temp.Capacity; n++)
                {
                    temp.Add(alllocations[i, n]);
                    z = z + alllocations[i, n] * alllocations[i, n];
                }
                calculated.Add(new List<double> { Math.Sqrt(z), i });
                arraytolist.Add(temp);
            }
            calculated = calculated.OrderBy(lst => lst[0]).ToList();
            var firstnitems = calculated.Take(number);
            foreach (var item in firstnitems)
            {
                result.Add(arraytolist[(int)item[1]]);
            }
            return result;
        }
        public static int[] CellChangeWithDate(int[] states, int days)
        {

            int[] result = new int[states.GetLength(0)];
            int[] newCurrentState = new int[states.GetLength(0) + 2];
            newCurrentState[0] = 0;
            for (int i = 0; i < states.GetLength(0); i++)
            {
                newCurrentState[i + 1] = states[i];
            }
            newCurrentState[states.GetLength(0) + 1] = 0;
            while (days > 0)
            {
                for (int i = 0; i < newCurrentState.GetLength(0) - 2; i++)
                {
                    result[i] = newCurrentState[i] == newCurrentState[i + 2] ? 0 : 1;
                    if (i == result.GetLength(0))
                        break;
                }
                days--;
                newCurrentState[0] = 0;
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    newCurrentState[i + 1] = result[i];
                }
                newCurrentState[result.GetLength(0) + 1] = 0;

            }
            return result;
        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            int playerA = 0;
            int playerB = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    playerA++;
                else if (a[i] < b[i])
                    playerB++;
            }
            result.Add(playerA);
            result.Add(playerB);

            return result;
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int matrixLength = arr.Count;
            int primaryDiag = 0;
            int secondaryDiag = 0;
            int result = 0;

            for (int i = 0; i < matrixLength; i++)
            {
                primaryDiag += arr[i][i];
                secondaryDiag += arr[i][matrixLength - 1 - i];
            }
            result = Math.Abs(primaryDiag - secondaryDiag);
            return result;
        }

        public static void plusMinus(int[] arr)
        {
            double positive = 0;
            double negative = 0;
            double zero = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] > 0)
                    positive += 1;
                else if (arr[i] < 0)
                    negative += 1;
                else if (arr[i] == 0)
                    zero += 1;
            }
            Console.WriteLine((positive / arr.GetLength(0)).ToString());
            Console.WriteLine((negative / arr.GetLength(0)).ToString());
            Console.WriteLine((zero / arr.GetLength(0)).ToString());
        }
        public static void staircase(int n)
        {
            string output = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                output += "#";
                Console.WriteLine("{0," + n + "}", output);
            }
        }
        public static void miniMaxSum(int[] arr)
        {
            long[] sums = new long[arr.GetLength(0)];
            long[] descsums = new long[arr.GetLength(0)];
            long[] reversesums = new long[arr.GetLength(0)];
            long sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int x = 0; x < arr.GetLength(0); x++)
                {
                    if (x != i)
                        sum += arr[x];
                }
                sums[i] = sum;
                sum = 0;
            }
            descsums = sums.OrderBy((a) => a).ToArray();
            reversesums = sums.OrderByDescending((a) => a).ToArray();
            Console.WriteLine(descsums[0] + " " + reversesums[0]);
        }
        public static int birthdayCakeCandles(int[] ar)
        {
            int maxLength = ar.Max();
            return ar.Count(it => it == maxLength);             
        }
        public string timeConversion(string s)
        {
            string result=string.Empty;
            string date = "01/01/2017 ";
            DateTime d = Convert.ToDateTime(date + s);
            result = String.Format("{0:HH:mm:ss}", d);
            return result;
        }
        public static int formingMagicSquare(int[][] s)
        {
            int result = 0;
            int index = 0;
            int[] multipleVal;
            for (int i = 0; i < s.GetLength(0); i++)
            {
                for(int y;y<s.GetLength(1);y++)
                {

                    if (s.Count(x => x == s[i][y]) > 1)
                    {
                        multipleVal[index] = s[i];
                        index++;
                    }
                }
            }
            return result;
        }
    }
}

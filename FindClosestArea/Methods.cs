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
            string result = string.Empty;
            string date = "01/01/2017 ";
            DateTime d = Convert.ToDateTime(date + s);
            result = String.Format("{0:HH:mm:ss}", d);
            return result;
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38)
                {
                    if ((5 - grades[i] % 5) < 3)
                        grades[i] = (grades[i] + (5 - grades[i] % 5));
                }
            }
            return grades;
        }
        public static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;
            for (int i = 0; i < apples.GetLength(0); i++)
            {
                apples[i] = apples[i] + a;
            }
            for (int i = 0; i < oranges.GetLength(0); i++)
            {
                oranges[i] = oranges[i] + b;
            }
            for (int i = 0; i < apples.GetLength(0); i++)
            {
                if (s <= apples[i] && apples[i] <= t)
                {
                    appleCount += 1;
                }
            }
            for (int i = 0; i < oranges.GetLength(0); i++)
            {
                if (s <= oranges[i] && oranges[i] <= t)
                {
                    orangeCount += 1;
                }
            }
            Console.WriteLine(appleCount.ToString());
            Console.WriteLine(orangeCount.ToString());
        }
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string result = "NO";
            for (int i = 1; i <= 10000; i++)
            {
                x1 += v1;
                x2 += v2;
                if (x1 == x2)
                {
                    result = "YES";
                    break;
                }
            }
            return result;
        }
        public static int getTotalX(List<int> a, List<int> b)
        {
            List<int> firstDivList = new List<int>();
            List<int> exactDivList = new List<int>();
            int counter = 0;

            for (int firstDiv = a.Last(); firstDiv <= b.First(); firstDiv++)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (firstDiv % a[i] == 0 && firstDivList.IndexOf(firstDiv) == -1)
                        counter += 1;
                }
                if (counter == a.Count)
                {
                    firstDivList.Add(firstDiv);
                }
                counter = 0;
            }
            for (int y = 0; y < firstDivList.Count; y++)
            {
                for (int x = 0; x < b.Count; x++)
                {
                    if (b[x] % firstDivList[y] == 0 && exactDivList.IndexOf(firstDivList[y]) == -1)
                        counter += 1;
                }
                if (counter == b.Count)
                {
                    exactDivList.Add(firstDivList[y]);
                }
                counter = 0;
            }
            return exactDivList.Count;
        }
        public static int[] cellCompete(int[] states, int days)
        {
            int[] result = new int[states.GetLength(0)];
            while (days > 0)
            {
                for (int i = 0; i < states.GetLength(0); i++)
                {
                    if (i == 0)
                    {
                        if (0 == states[i + 1])
                            result[i] = 0;
                        else
                            result[i] = 1;
                    }
                    else if (i == states.GetLength(0) - 1)
                    {
                        if (0 == states[i - 1])
                            result[i] = 0;
                        else
                            result[i] = 1;
                    }
                    else
                    {
                        if (states[i - 1] == states[i + 1])
                            result[i] = 0;
                        else
                            result[i] = 1;
                    }
                }
                days--;
                for (int x = 0; x < result.GetLength(0); x++)
                {
                    states[x] = result[x];
                }
            }
            return result;
        }
        public static int generalizedGCD(int num, int[] arr)
        {
            int index = arr.GetLength(0) - 1;
            int result = 0;
            int counter = 0;

            while (num > 0)
            {
                for (int x = 0; x < arr.GetLength(0); x++)
                {
                    if (arr[x] % arr[index] == 0)
                        counter += 1;
                }
                result = counter == arr.GetLength(0) ? arr[index] : 1;
                counter = 0;
                index -= 1;
                num--;
            }
            return result;
        }
        public static int getMultiples(int first, int second, int maxVal)
        {
            int firstMultiple = 0;
            int secondMultiple = 0;
            int commonMultiple = 0;
            for (int i = first; i < maxVal; i++)
            {
                if (i % first == 0 && i % second == 0)
                    commonMultiple += i;
                else if (i % first == 0)
                    firstMultiple += i;
                else if (i % second == 0)
                    secondMultiple += i;
            }
            return firstMultiple + secondMultiple + commonMultiple;
        }

        //public static long fibonacciSeries(int maxVal)
        //{
        //    long result = 0;
        //    List<int> fibSeries = new List<int>();
        //    fibSeries.Add(1);
        //    fibSeries.Add(2);
        //    for (int x = 2; x < maxVal; x++)
        //    {
        //        fibSeries.Add(fibSeries[x - 2] + fibSeries[x - 1]);
        //    }
        //    foreach (var item in fibSeries)
        //    {
        //        if (item % 2 == 0)
        //            result += item;
        //    }

        //    return result;
        //}

        public static int[] breakingRecords(int[] scores)
        {
            int[] result = new int[2];
            int bestScore = scores.First();
            int worstScore = scores.First();
            int bestScoreCnt = 0;
            int worstScoreCnt = 0;
            for (int i = 1; i < scores.GetLength(0); i++)
            {
                if (scores[i] > bestScore)
                {
                    bestScore = scores[i];
                    bestScoreCnt += 1;
                }
                else if (scores[i] < worstScore)
                {
                    worstScore = scores[i];
                    worstScoreCnt += 1;
                }
            }
            result[0] = bestScoreCnt;
            result[1] = worstScoreCnt;
            return result;
        }
    }
}

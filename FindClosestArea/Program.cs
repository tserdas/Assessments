using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessments
{
    class Program
    {
        static void Main()
        {
            #region FindClosestArea
            //int[,] locations = { { 2, 7 }, { 2, 4 }, { 2, 8 }, { 2, 6 }, { 2, 3 }, { 2, 5 } };
            //int total = 6;
            //int findnumber = 2;
            //List<List<int>> result1 = Methods.FindClosestArea(total, locations, findnumber);
            //foreach (var elements in result1)
            //{
            //    foreach (var element in elements)
            //    {
            //        Console.WriteLine(element);
            //    }
            //}
            #endregion
            #region CellChangeWithDate
            //int[] example = { 1, 0, 0, 0, 0, 1, 0, 0 };
            //int[] result2 = new int[8];
            //result2 = Methods.CellChangeWithDate(example, 1);
            //for (int i = 0; i < result2.GetLength(0); i++)
            //{
            //    Console.WriteLine(result2[i].ToString());
            //}
            #endregion
            #region diagonalDifference
            //List<List<int>> diagdiffsource = new List<List<int>>();
            //int result3 = 0;
            //diagdiffsource.Add(new List<int>() { 11, 2, 4 });
            //diagdiffsource.Add(new List<int>() { 4, 5, 6 });
            //diagdiffsource.Add(new List<int>() { 10, 8, -12 });
            //result3 = Methods.diagonalDifference(diagdiffsource);
            //Console.WriteLine(result3.ToString());
            #endregion
            #region plusMinus
            //int[] plusMinusSource = { -4, 3, -9, 0, 4, 1 };
            //Methods.plusMinus(plusMinusSource);
            #endregion
            #region staircase
            //Methods.staircase(6);
            #endregion
            #region miniMaxSum
            //int[] minMaxSumSource = { 156873294 ,719583602 ,581240736 ,605827319 ,895647130 };
            //Methods.miniMaxSum(minMaxSumSource);
            #endregion
            #region birthdayCakeCandles

            #endregion
            #region formingMagicSquare
            int[,] formingMagicSquare = { { 4, 8, 2 }, { 4, 5, 7 }, { 6, 1, 6 } };
            #endregion
            #region gradingStudents
            //List<int> gradingStudents = new List<int> {23,80,96,18,73,78,60,60,15,45,15,10,5,46,87,33,60,14,71};
            //List<int> result = Methods.gradingStudents(gradingStudents);
            //Console.WriteLine("sonuc");
            #endregion
            #region countApplesAndOranges
            //int[] apples = { -2, 2, 1 };
            //int[] oranges= { 5, -6 };
            //Methods.countApplesAndOranges(7, 11, 5, 15, apples, oranges);
            #endregion
            #region kangaroo
            #endregion
            #region getTotalX
            //List<int> a = new List<int>(){2,4 };
            //List<int> b = new List<int>() { 16, 32,96 };
            //Methods.getTotalX(a, b);
            #endregion
            #region cellComplete
            //int[] example = { 1, 1, 1, 0, 1, 1, 1, 1 };
            //int[] result2 = new int[8];
            //result2 = Methods.cellCompete(example, 2);
            //for (int i = 0; i < result2.GetLength(0); i++)
            //{
            //    Console.WriteLine(result2[i].ToString());
            //}
            #endregion
            #region generalizedGCD
            //int[] example = { 2, 4, 6, 8, 10 };
            //Methods.generalizedGCD(example.GetLength(0), example);
            #endregion
            #region getMultiples            
            //Console.WriteLine(Methods.getMultiples(3, 5, 1000).ToString());
            #endregion
            #region fibonacciSeries
            //Console.WriteLine(Methods.fibonacciSeries(4000000).ToString());
            #endregion
            #region breakingRecords
            int[] example = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            int[] result = new int[2];
            result = Methods.breakingRecords(example);
            #endregion

            //string input = "Jack and Jill went to the market to buy bread and cheese. Cheese is Jack's and Jill's favorite food.";
            //List<string> exclude = new List<string>();
            //exclude.Add("and");
            //exclude.Add("he");
            //exclude.Add("the");
            //exclude.Add("to");
            //exclude.Add("is");
            //Methods.retrieveMostFrequentlyUsedWords(input, exclude);

            int[] arr = { 64, 25, 12, 22, 11 };
            GeekforGeeksMethods.selectionSort(arr);

        }
    }
    
    static class GeekforGeeksMethods
    {
        public static int linearSearch (int[] arr,int x)
        {
            int result = -1;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == x)
                    result = i;
            }
            return result;
        }
        public static int binarySearch (int[] arr,int l,int r,int x)
        {
            int result=-1;
            if (r >= l)
            {

                int mid = l+ (r-1)/2;
                if (arr[mid] == x)
                    result = mid;
                else if (arr[mid] > x)
                    binarySearch(arr, l, mid - 1, x);
                else
                    binarySearch(arr, l, mid + 1, x);
            }
            return result;
        }
        public static int[] selectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
        public static int[] bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i] 
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
            return arr;
        }
    }
}

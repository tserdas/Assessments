using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessments
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}

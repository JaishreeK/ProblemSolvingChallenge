using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testHackerRank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            // int n = Convert.ToInt32(Console.ReadLine());

            // int[] grades = new int[n];

            //for (int gradesItr = 0; gradesItr < n; gradesItr++)
            //{
            //    int gradesItem = Convert.ToInt32(Console.ReadLine());
            //    grades[gradesItr] = gradesItem;
            //}

            // int[] result = gradingStudents(grades);

            //tw.WriteLine(string.Join("\n", result));

            //tw.Flush();
            //tw.Close();
            //Tuple<int, int> counts = countApplesAndOranges(s, t, a, b, apples, oranges);
            return ;
       }


        // Complete the kangaroo function below.
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (!((x2 > x1) && (v2 > v1)))
            {
                for (int j = 0; j < 100; j++)
                {
                    if (x1 + j * (v1) == x2 + j * (v2))
                        return "Yes";
                }
            }
            return "No";
        }

        public static Tuple<int, int> countApplesAndOranges(int s, int t, int a, int b, int m, int n, int[] apples, int[] oranges)
        {
            //house interval s and t
            //location of the tree a and b
            //count of apple =m, orange=n
            //apples fall distance array
            //orange fall distance array

            //range to check is s and t
            //a=apple location
            //b = orange location
            int[] distApples = new int[apples.Length];
            int[] distOranges = new int[oranges.Length];
            int countA=0, countO=0;
            for(int i=0;i<m;i++)
            {
                distApples[i] = a + apples[i];
                if (distApples[i] <= t && distApples[i] >= s)
                    countA += 1;

            }

            for (int i = 0; i < n; i++)
            {
                distOranges[i] = b + oranges[i];
                if (distOranges[i] <= t && distOranges[i] >= s)
                    countO+= 1;
            }

            var countAnO = new Tuple<int, int>(countA, countO);
            return countAnO;
        }

        // Complete the sockMerchant function below.
        //public static int[] gradingStudents(int[] grades)
        //{
        //    int size = grades.Length;
        //    int[] roundedVal = new int[size];
        //    for (int i = 0; i < size; i++)
        //    {
        //        if ((grades[i] <38) || (grades[i] % 5 < 3))
        //            roundedVal[i] = grades[i];                
        //        else
        //            roundedVal[i] = grades[i] + (5 - grades[i] % 5);
        //    }
        //    return roundedVal;
        //}      
        
            
         // Complete the sockMerchant function below.
         static long VeryBigSum(int[] ar)
        {
           int size = ar.Length;
           long sum = 0;
            for (int i = 0; i < size; i++)
            {
                 sum +=ar[i];
            }
            return sum;
        } 
        

         // Complete the diagonalDifference function below.
        public static int diagonalDifference(int[,] arr) {

            int rows = arr.GetLength(0);
            int cols = rows;        
            int sumDia1 =0,sumDia2=0;            
            for(int i=0;i<rows;i++)
            {
                sumDia1+=arr[i,i];
            }
            for(int i=0;i<rows;i++)
            {
                if (cols >= 0)
                {
                    sumDia2 += arr[i, cols - 1];
                    cols--;
                }
                else
                    break;
            }
            return Math.Abs(sumDia1-sumDia2);    
        }
        
    }
}

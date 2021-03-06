﻿using System;
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


        // Complete the plusMinus function below.
        public static void plusMinus(int[] arr)
        {
            int n = arr.Length;
            int count0 = 0, countP = 0, countN = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                    count0 += 1;
                else if(arr[i] < 0)
                    countN += 1;
                else
                    countP += 1;
            }
           
            Console.WriteLine("{0:0.000000}", (double)countP / n);
            Console.WriteLine("{0:0.000000}", (double)countN / n);
            Console.WriteLine("{0:0.000000}", (double)count0 / n);
        }

        // Complete the staircase function below.
        public static void Staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string hashStr = "";
                string spaceStr = "";
                //insert n-i spaces and i #
                int spaceCnt = n - i;
                int hashCount = i;

                for (int p = 1; p <= n - i; p++)
                    spaceStr = spaceStr + " ";


                while (hashCount > 0)
                {
                    hashStr = hashStr + "#";
                    hashCount--;
                }
                Console.WriteLine(spaceStr + hashStr);
            }
        }


        public static void EasyFormatting(int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
        }

        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            //sample input 1,2,3,4,5  //output 10,14

            //use int64 datatypes for sum
            Int64 sum = 0;
            Int64 min=Int64.MaxValue, max = Int64.MinValue;
                      
            for(int i=0;i<5;i++)
            {
                sum = sum + arr[i];

                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];
            }          
            Console.WriteLine(sum - max + ":MinSum");
            Console.WriteLine(sum - min + ":MaxSum");
        }
        
        // Complete the birthdayCakeCandles function below.
        public static int birthdayCakeCandles(int[] ar)
        {
            int maxCount = 0;
            int max = 0;            
            for(int i=0;i<ar.Length;i++)
            {
                if (max < ar[i])
                {
                    max = ar[i];
                    maxCount++;
                }
                else if(max==ar[i])
                {
                    maxCount++;
                }
            }
            return maxCount;

        }

        /*
    * Complete the timeConversion function below.
    */
        static string timeConversion(string s)
        {
            string timeString24 = "";
            string amorPM = s.Substring(8, 2);
            s = s.Remove(8, 2);
            string[] times = s.Split(':');
            int hh = int.Parse(times[0]);
            if (amorPM == "AM")
            {
                if (hh == 12)
                    times[0] = "00";
            }
            else
            {
                if (hh<12)          
                    times[0] = (hh + 12).ToString();                
            }
            timeString24 = string.Join(":", times);
            return timeString24;
        }

        static int getTotalX(int[] a, int[] b)
        {
            int f = lcm(a);
            int l = gcd(b);
            int count = 0;
            for (int i = f, j = 2; i <= l; i = f * j, j++)
            {
                if (l % i == 0) { count++; }
            }
            return count;
        }

        private static int gcd(int[] a)
        { 
            
            int FirstVal = a[0];
            for(int i=1;i<a.Length;i++)
            {
               FirstVal= gcd(FirstVal, a[i]);
            }
            return FirstVal;
        }

        private static int gcd(int a, int b)
        {
            int temp;
            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
           return a;
        }

        private static int lcm(int a, int b)
        {
            return a * (b / gcd(a, b));
        }

        private static int lcm(int[] input)
        {
            int result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                result = lcm(result, input[i]);
            }
            return result;
        }


        // Complete the breakingRecords function below.
        public static int[] breakingRecords(int[] scores)
        {
            int[] minMaxScores = new int[2] { 0, 0 };
            int min = scores[0];
            int max = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                    minMaxScores[1]++;
                }
                else if (scores[i] < min)
                {
                    min = scores[i];
                    minMaxScores[0]++;
                }                
            }
            return minMaxScores;
        }

        // Complete the birthday function below.
        public static int birthdayChoc(List<int> s, int d, int m)
        {
            int sumD=0, count = 0;      
            for (int i = 0; i < s.Count; i++)
            {
                sumD = sumD + s[i];
                if (i > m - 1)
                    sumD -= s[i - m];
                if(i>=m-1 && sumD==d)
                    count++;               
            }
           
            return count;
        }


        // Complete the divisibleSumPairs function below.
        public static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0, sum;
            for (int i = 0; i < n; i++)
            {
                sum = ar[i];
                for (int j = i+1; j < n; j++)
                {
                    if ((sum + ar[j]) % k == 0)
                        count++;              

                }
            }
            return count;

        }

        // Complete the migratoryBirds function below.
        public static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> dictBirdsCounts = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (dictBirdsCounts.ContainsKey(item))
                    dictBirdsCounts[item] += 1;
                else
                    dictBirdsCounts.Add(item, 1);
            }
            //return dictBirdsCounts.OrderBy(x=>x.Key).Max(x=>x.Value);
            int max = dictBirdsCounts.OrderBy(x => x.Key)
                    .OrderByDescending(x => x.Value)
                    .First().Key;
            return max;
        }


        // Complete the dayOfProgrammer function below.
        public static string dayOfProgrammer(int year)
        {
            if (year < 1918)
            {
                if (year % 4 == 0)
                    return new DateTime(year, 9, 12).ToString("dd.MM.yyyy");
                else
                    return new DateTime(year, 9, 13).ToString("dd.MM.yyyy");

            }
            else if (year == 1918)
            {
                return new DateTime(year, 9, 26).ToString("dd.MM.yyyy");
            }
            else
            {

                if ((year % 4 == 0) && (!(year % 100 == 0)))
                    return new DateTime(year, 9, 12).ToString("dd.MM.yyyy");
                else
                {
                    //check for 1800
                    if (year % 400 == 0)
                        return new DateTime(year, 9, 12).ToString("dd.MM.yyyy");
                    else
                        return new DateTime(year, 9, 13).ToString("dd.MM.yyyy");
                }

            }
        }

        // Complete the bonAppetit function below.
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int bCharged, bPaid;
            bPaid = b;
            bill.RemoveAt(k);
            bCharged = (int)bill.Sum() / 2;
            if (bCharged - bPaid == 0)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine((bCharged - bPaid).ToString());


        }
    }   
    
}

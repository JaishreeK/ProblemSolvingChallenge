using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testHackerRank
{
    class ProgramSockMerchant
    {
        static void Main1(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            //;
            //int result = sockMerchant(n, ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            Dictionary<int, int> colorDict = new Dictionary<int, int>();
            int pairCount = 0;
            for (int i = 0;  i<ar.Length; i++)
            {
                int color = ar[i];

                if (colorDict.ContainsValue(color))
                {
                    pairCount++;
                    colorDict.Remove(colorDict.FirstOrDefault(m => m.Value == color).Key);

                }
                else
                    colorDict.Add(i, color);
                
                 
            }

            return pairCount;
        }
    }
}

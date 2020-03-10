using System;
using System.IO;

namespace SimpleArraySum
{
    class Program
    {
        static int simpleArraySum(int[] ar)
        {
            int sum = 0;
            foreach (int number in ar)
            {
                sum += number;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = simpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

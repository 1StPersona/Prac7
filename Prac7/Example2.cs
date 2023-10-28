using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac7
{
    public class Example2
    {
        private static Random rand = new Random();
        private int[] arr = new int[10];

        private int sum = 0;

        public Example2()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }
        }

        public int getSum()
        {
            foreach(int x in arr)
            {
                sum += x;
            }
            return sum;
        }

        public static bool operator <(Example2 ex1, Example2 ex2)
        {
            return ex1.getSum() < ex2.getSum();
        }
        public static bool operator >(Example2 ex1, Example2 ex2)
        {
            return ex1.getSum() > ex2.getSum();
        }

        public void showArrAndSum()
        {
            foreach(int x in arr)
                Console.Write(x + " ");

            Console.WriteLine("\n\nSum: {0}", this.getSum());
            Console.WriteLine();
        }
    }
}

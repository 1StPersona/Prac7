using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prac7
{
    public class Array3
    {
        private static Random rand = new Random();
        private int[] arr = new int[10];

        public Array3()
        {
            for(int i = 0; i < arr.Length; i++)
                this.arr[i] = rand.Next(10);
        }
        public Array3(int length)
        {
            arr = new int[length];
        }

        public int this [int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public static implicit operator int(Array3 arr)
        {
            return arr.getLength();
        }

        public static Array3 operator *(Array3 arr1, Array3 arr2)
        {
            int maxLen = 0;
            Array3 res = null;
            if (arr1.getLength() > arr2.getLength()) {
                maxLen = arr1.getLength();
                res = new Array3(maxLen);
                for (int i = 0; i < arr2.getLength(); i++)
                {
                    res[i] = arr1[i] * arr2[i];
                }
                for (int i = arr2.getLength() - 1; i < maxLen; i++)
                {
                    res[i] = arr1[i] * arr2[i];
                }
            }
            else { 
                maxLen = arr2.getLength();
                res = new Array3(maxLen);
                for (int i = 0; i < arr1.getLength(); i++)
                {
                    res[i] = arr1[i] * arr2[i];
                }
                for (int i = arr1.getLength() - 1; i < maxLen; i++)
                {
                    res[i] = arr1[i] * arr2[i];
                };
            }
            return res;
        }

        public static bool operator ==(Array3 arr1, Array3 arr2)
        {
            for(int i = 0; i < arr1.getLength(); i++)
                if (arr1[i] != arr2[i]) return false;
             
            return true;
        }
        public static bool operator !=(Array3 arr1, Array3 arr2)
        {
            for (int i = 0; i < arr1.getLength(); i++)
                if (arr1[i] != arr2[i]) return true;

            return false;
        }

        public static bool operator >=(Array3 arr1, Array3 arr2)
        {
            if (arr1.getLength() <= arr2.getLength() && arr1.getSum() <= arr2.getSum()) return false;
            else return true;
        }
        public static bool operator <=(Array3 arr1, Array3 arr2)
        {
            if (arr1.getLength() <= arr2.getLength() && arr1.getSum() <= arr2.getSum()) return true;
            else return false;
        }

        public int getSum()
        {
            int sum = 0;
            foreach (int x in arr)
                sum += x;
            return sum;
        }

        public int getLength()
        {
            return arr.Length;
        }

        public void showArr()
        {
            foreach(int x in arr)
            {
                Console.Write(x+" \t");
            }
            Console.WriteLine("");
        }
    }
}

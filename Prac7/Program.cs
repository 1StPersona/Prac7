using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Example1 ex1 = new Example1(1, "1", 2000.23);
            Example1 ex2 = new Example1(2, "2", 2000.23);
            Console.WriteLine(ex1 == ex2);
            Console.WriteLine(ex1 != ex2);
            Console.WriteLine(ex1.Equals(ex2));


            ////////////////////////////////////////
            Console.WriteLine("\n-------------------\n");

            Example2 ex3 = new Example2();
            Example2 ex4 = new Example2();
            ex3.showArrAndSum();
            ex4.showArrAndSum();
            Console.WriteLine(ex3 > ex4);

            ////////////////////////////////////////
            Console.WriteLine("\n-------------------\n");

            Array3 arr1 = new Array3();
            arr1.showArr();
            Array3 arr2 = new Array3();
            arr2.showArr();
            Array3 res = arr1 * arr2;
            res.showArr();
            Console.WriteLine(arr1 >= arr2);
            Console.WriteLine(arr1 == arr2);
        }
    }
}

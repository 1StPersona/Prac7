using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prac7
{
    public class Example1
    {
        private int id;
        private string name;
        private double salary;

        public Example1() { }
        public Example1(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public static bool operator ==(Example1 ex1, Example1 ex2)
        {
            return ex1.salary == ex2.salary;
        }
        public static bool operator !=(Example1 ex1, Example1 ex2)
        {
            return ex1.salary != ex2.salary;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

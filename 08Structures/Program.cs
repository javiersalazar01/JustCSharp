using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalStruct ns1 = new NormalStruct(1);
            NormalStruct ns2 = ns1;
            ns2.attribute = 20;
            Console.WriteLine(ns1.attribute);
            
            NormalClass nc1 = new NormalClass(1);
            NormalClass nc2 = nc1;
            nc2.attribute = 20;
            Console.WriteLine(nc1.attribute);

            Console.ReadLine();

        }
    }

    public class NormalClass
    {
        public int attribute;
        public NormalClass(int value)
        {
            attribute = value;
        }
    }

    public struct NormalStruct
    {
        public int attribute;

        public NormalStruct(int x)
        {
            attribute = x;
        }
    }
}

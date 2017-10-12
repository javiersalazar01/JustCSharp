using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();

            myList.Add(1);
            myList.Add(2123);
            myList.Add(34);
            myList.Add(4);
            myList.Add(10);
            myList.Add(23);

            /*EachDelegate ed = new EachDelegate(Select);

            List <int> newList = myList.each(ed);

            Console.WriteLine(String.Join(",",newList));*/

            List<int> list = myList.each(i => i < 100);
            Console.WriteLine(String.Join(",", list));


            MySecondDelegate msd = new MySecondDelegate(sayHi);
            msd("popo");
            msd("caca");


            
            Console.ReadLine();

        }

        /*static bool Select (int item)
        {
            if (item > 10)
            {
                return true;
            }

            return false;
        }*/


        static void sayHi(string message)
        {
            Console.WriteLine(message);
        }
    }

    
    public delegate bool EachDelegate(int item);

    public class MyList
    {
        private List<int> _myList;

        public MyList()
        {
            _myList = new List<int>();
        }

        public void Add(int element)
        {
            _myList.Add(element);
        }

        public void RemoveAt(int index)
        {
            _myList.RemoveAt(index);
        }

        public List<int> each(EachDelegate MyDelegate)
        {
            List<int> res = new List<int>();

            foreach (int item in _myList)
            {
                if (MyDelegate(item))
                {
                    res.Add(item);
                }
            }
            
            return res;

        }

    }

    public delegate void MySecondDelegate(string message);
}

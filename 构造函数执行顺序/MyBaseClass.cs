using System;
using System.Collections.Generic;
using System.Text;

namespace 构造函数执行顺序
{
    public class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine("Base 0");
        }

        public MyBaseClass(int i)
            : this()
        {
            Console.WriteLine("Base 1");
        }

        public MyBaseClass(int i, int j)
        {
            Console.WriteLine("Base 2");
        }
    }


    public class MyDrivedClass : MyBaseClass
    {
        public MyDrivedClass()
            : base(0)
        {
            Console.WriteLine("Drived 0");
        }

        public MyDrivedClass(int i)
        {
            Console.WriteLine("Drived 1");
        }

        public MyDrivedClass(int i, int j)
            : base(i, j)
        {
            Console.WriteLine("Drived 2");
        }
    }
}

using System;

namespace 构造函数执行顺序
{
    class Program
    {
        static void Main(string[] args)
        {
            //执行顺序System.Object()->MyBaseClass()->MyBaseClass(int i)->MyDrivedClass()
            MyDrivedClass md = new MyDrivedClass();

            //执行顺序System.Object()->MyBaseClass()->MyDrivedClass(int i)
            int i = 0;
            MyDrivedClass md1 = new MyDrivedClass(i);

            //若要不执行默认构造函数，需要添加继承base(canshu)或this(canshu)
            //执行顺序System.Object()->MyBaseClass()->MyBaseClass(int i)->MyDrivedClass(int i, int j)
            MyDrivedClass mdc = new MyDrivedClass(7, 8);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//为什么命名空间可以一样，而类名不可以一样？
//1、类型所在的命名空间主要用于标识类型所在的程序集，所以内部可以使用共同的标识
//2、namespace 命名空间，可以被多类使用，标识这些类都在同一个命名空间下
//3、同一个命名空间不允许出现相同的类型名称，不同的命名空间可以出现相同的类型名称

namespace A
{
    class Class1
    {
        public void Display()
        {
            Console.WriteLine("Class1");
        }
    }
    class Class2
    {
        public void Display()
        {
            Console.WriteLine("Class2");
        }
    }
}

namespace A
{ 
    class Class3 
    {
        public void Display()
        {
            Console.WriteLine("Class3");
        }
    }
    class Class4
    {
        public void Display()
        {
            Console.WriteLine("Class4");
        }
    }
}

namespace B
{ 
    class Class1
    {
        public void Display()
        {
            Console.WriteLine("Class5");
        }
    }
    class Class2
    {
        public void Display()
        {
            Console.WriteLine("Class6");
        }
    }
}

namespace SetUp
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("start with me");
            Console.ReadLine();
        }
    }
}

namespace Test
{
    class A
    {
        public static void ADD(int a , int b)
        {
            Console.WriteLine(a + b);
        }
     
    }
}
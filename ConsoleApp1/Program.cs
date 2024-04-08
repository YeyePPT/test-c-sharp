using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program                //为什么main函数需要静态的？？？
    {
        static void Main(string[] args) //因为程序运行初期，内存中没有任何对象，这个时候要运行必须有一个起始点，而静态是作为程序初始化默认分配的内存空间，所以直接调取。
        {
            Console.Write("hello,World"); //这是行注释，
            Console.ReadLine();
            /*  这是块注释
             * 
             * 
             * 
             * 
             * 
             */
            Console.WriteLine("sdvds");
            Console.ReadLine(); 
            StringBuilder stuff = new StringBuilder();
            new A.Class1().Display();//有重名的类，需要完全限定
            new B.Class1().Display();
            Console.ReadLine();
        }
    }
} 
//启动项可以改！！！


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project;

class Class1

{

    static void Main()
    {
        //        声明一个数组ids，存放若干整数，利用：
        //while
        //for循环 i--
        //输出数组中每个元素的值

        //int[] ids;
        //ids = new int[] { 21, 32, 421, 4124, 515 };

        int[] ids = { 21, 32, 421, 4124, 515 };
        int i = 0;//声明的同时赋值
        while (i < ids.Length)
        {

            Console.WriteLine(ids[i]);
            i++;


        }





    }

}




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

        //        声明变量age（年龄），写一段代码能根据age输出文本：成年（满18岁），或者未成年（未满18岁）
        //          let age /*补足*/;
        //        if (age /*补足*/ 18){
        //            alert(/*补足*/);
        //        }/*补足*/



        //不考虑输入负数的和太大的只拿18做判断

        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("成年了");
        }
        else
        {

            Console.WriteLine("未成年");

        }











    }


}




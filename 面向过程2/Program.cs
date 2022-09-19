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

        //            声明一个变量number，给number赋整数值，写出以下表达式，判断number是不是：
        //正数，示例：
        //number > 0
        //大于100的正数
        //大于100小于1000的正数
        //10000以内能被3整除的奇数


        int number;
        number = int.Parse(Console.ReadLine());
        if (number > 0)
        {

            Console.WriteLine(number + "是正数");

        }
        else {

            Console.WriteLine("重新输入");
        
        }
    
    }

}




            

        








    










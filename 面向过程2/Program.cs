using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Class1

    {

        static void Main()
        {

            //写一段代码，能根据半径获取圆的周长（= 2倍半径乘以圆周率）和面积（= 半径的平方乘以圆周率）
            //声明一个变量radius，代表半径，给它赋一个任意值；
            //使用alert(/*这里放表达式*/)输出周长;
            //使用alert(/*这里放表达式*/)输出面积;
            double pai, radius;
            pai = 3.14F;
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine("周长="+2*radius*pai);  
            Console.WriteLine("面积="+radius*pai*radius);

            


        }




    }





}







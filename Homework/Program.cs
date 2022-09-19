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
        //声明一个数组odds，利用循环把100以内的不能被3整除的数按从小到大的顺序存入其中
        int i, j, k = 0, count = 0;


        for (i = 0; i < 100; i++)
        {
            if (0 != i % 3)
            {
                count++;
            }
            //elsenothing
        }

        int[] odds;
        odds = new int[count];
        for (j = 0; j < 100; j++)
        {
            if (0 != j % 3)
            {
                odds[k] = j;
                k++;
            }
            //elsenothing
        }

        //Console.WriteLine(odds);

        //int l=0;
        //for (l = 0; l < odds.Length; l++) { 


        //Console.WriteLine(odds[l]);

        //}检测
        //int m = 0;
        //int sum = 0;
        //for (m = 0; m < odds.Length; m++)
        //{
        //    sum += odds[m];

        //}
        //Console.WriteLine(sum);

        //同时/一次性找到并输出数组中的最大最小值
        int max, min, n;
        max = odds[0];
        min = odds[0];
        for (n = 0; n < odds.Length; n++)
        {
            if (max < odds[n])
            {
                max = odds[n];
            }
            //elsenothing
            if (min > odds[n])
            {
                min = odds[n];

            }
            //elsenothing


        }
        Console.WriteLine(max);
        Console.WriteLine(min);
        //提出问题 可以一次console.writeline max 和min吗？

    }

}




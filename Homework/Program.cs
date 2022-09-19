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

        }

        Console.WriteLine(odds);

        //int l=0;
        //for (l = 0; l < odds.Length; l++) { 


        //Console.WriteLine(odds[l]);

        //}检测


    }

}




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
        //分别利用while和for循环，计算出1000 + 999 + 998 + 997 +……+100/*的值*/
        int i, sum;

        sum = 0;
        for (i = 100; i <= 1000; i++)
        {
            sum += i;

            Console.WriteLine(sum);



        }

    }

}



